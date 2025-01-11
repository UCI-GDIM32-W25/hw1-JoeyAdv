using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 1.0f;
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private GameObject _plantPrefab;
    [SerializeField] private int _numSeeds = 5; 
    [SerializeField] private PlantCountUI _plantCountUI;

    private int _numSeedsLeft;
    private int _numSeedsPlanted;

    private List<GameObject> seedsPlanted = new List<GameObject>();

    private void Start ()
    {
        // deletes the GameObject of every seed currently planted
        List<GameObject> SeedsToDestroy = new List<GameObject>();
        foreach (GameObject seedPlanted in seedsPlanted){
            SeedsToDestroy.Add(seedPlanted);
        }
        foreach (GameObject seed in SeedsToDestroy){
            DestroySeed(seed);
        }

        // resets the total seeds
        _numSeedsLeft = 5;
        _numSeedsPlanted = 0;
    }

    private void Update()
    {

        // PLAYER MOVEMENT
        if (Input.GetKey(KeyCode.W) & Input.GetKey(KeyCode.A)){
            _playerTransform.Translate(Vector3.up * _speed *Time.deltaTime);
            _playerTransform.Translate(Vector3.left * _speed *Time.deltaTime);
        } 
        // Checks for southwest movement
        else if (Input.GetKey(KeyCode.A) & Input.GetKey(KeyCode.S)){
            _playerTransform.Translate(Vector3.left * _speed *Time.deltaTime);
            _playerTransform.Translate(Vector3.down * _speed *Time.deltaTime);
        } 
        // Checks for southeast movement
        else if (Input.GetKey(KeyCode.S) & Input.GetKey(KeyCode.D)){
            _playerTransform.Translate(Vector3.down * _speed *Time.deltaTime);
            _playerTransform.Translate(Vector3.right * _speed *Time.deltaTime);
        } 
        // Checks for northeast movement
        else if (Input.GetKey(KeyCode.D) & Input.GetKey(KeyCode.W)){
            _playerTransform.Translate(Vector3.right * _speed *Time.deltaTime);
            _playerTransform.Translate(Vector3.up * _speed *Time.deltaTime);
        } 
        // checks for north movement
        else if (Input.GetKey(KeyCode.W)){
            _playerTransform.Translate(Vector3.up * _speed *Time.deltaTime);
        } 
        // checks for west movement
        else if (Input.GetKey(KeyCode.A)){
            _playerTransform.Translate(Vector3.left * _speed *Time.deltaTime);
        } 
        // checks for south movement
        else if (Input.GetKey(KeyCode.S)){
            _playerTransform.Translate(Vector3.down * _speed *Time.deltaTime);
        } 
        // checks for east movement
        else if (Input.GetKey(KeyCode.D)){
            _playerTransform.Translate(Vector3.right * _speed *Time.deltaTime);
        }

        // plants seed if player presses space
        if (Input.GetKeyDown(KeyCode.Space)){
            if(_numSeedsLeft > 0){
                PlantSeed();
                _numSeeds -= 1;
                _numSeedsLeft = _numSeeds;
                _numSeedsPlanted += 1;
            }
        }

        // updates the plant seed UI
        _plantCountUI.UpdateSeeds(_numSeedsLeft, _numSeedsPlanted);

    }

    public void PlantSeed ()
    {
        // if the player has seeds remaining, plants a seed at the player position
        if (_numSeeds > 0){
            GameObject plantObject = Instantiate(_plantPrefab, _playerTransform.position, _playerTransform.rotation);
            seedsPlanted.Add(plantObject);
        }
    }

    private void DestroySeed(GameObject seed){
        seedsPlanted.Remove(seed);
        Destroy(seed);
    }
}
