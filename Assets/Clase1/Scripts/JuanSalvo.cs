using TMPro;
using UnityEngine;

public class JuanSalvo : MonoBehaviour
{
    // 1. TAREA: Declarar variables para nombre, edad, altura (float) o lo que quieras.

    // Escribe tus variables aquí abajo: Recorda deben poder ser modificadas desde el inspector pero tambien ser privadas.

    [SerializeField] private string nombre = "Romi";
    [SerializeField] private int edad = 40;
    [SerializeField] private float altura = 1.65f;
    
    // ---------------------------------------------------------
    // (NO TOCAR)
    [Header("Referencias UI")]
    [SerializeField]
    private TextMeshProUGUI _uiText;
    private string _finalMessage;

    // ---------------------------------------------------------

    private void Start()
    {
        // Al iniciar, llamamos a la función que muestra los datos
        MostrarDatos();
        Contestar();

    }

    public void MostrarDatos()
    {
        // 2. TAREA: Construir la frase.
        // Asigna a la variable '_finalMessage' la concatenación de tus variables.

        // _finalMessage = ... (Escribe tu código aquí)

        // Mostrar en consola
        Debug.Log(_finalMessage =  nombre + " tiene " + edad + " años y " + altura + " metros de altura." );

        // ---------------------------------------------------------    
        // Actualizamos la UI visualmente no hace falta tocar esto
        ActualizarUI();
        // ---------------------------------------------------------
    }
    
    public void Contestar()
    {
        // 3. TAREA: Condicionales - Responder dependiendo algun parametro como nombre,edad o altura.
        //Ejemplo: si altura >= 2 -> "Fua estas para jugar en la NBA".
        if (nombre != "Romi")
        {
           _finalMessage = "Hola " + nombre + ", no sos Romi pero igual te saludo!";
        }
        else
        {
            _finalMessage = "Romi, un gusto saludarte!";
        }
        Debug.Log(_finalMessage);
        // _finalMessage = ... (Escribe tu código aquí)

        // ---------------------------------------------------------
        // Actualizamos la UI visualmente no hace falta tocar esto
        ActualizarUI();
        // ---------------------------------------------------------
    }

    #region No tocar
    //----------------------No Tocar------------------------
    private void ActualizarUI()
    {
        // ---------------------------------------------------------
        // Actualizamos la UI visualmente no hace falta tocar esto
        if (_uiText != null)
        {
            _uiText.text = _finalMessage;
        }
        else
        {
            Debug.LogError("¡Falta asignar el componente TextMeshPro al script en el Inspector!");
        }
        // ---------------------------------------------------------
    }
    #endregion
}
