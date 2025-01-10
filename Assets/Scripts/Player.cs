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

    private void Start ()
    {
        
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

        
    }

    public void PlantSeed ()
    {
        
    }
}
