using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class SaveSystem1 : MonoBehaviour
{
    private string filePath;
    public Vector3 lastPos;
    StreamWriter m_writer;

    void CreateFile()
    {
        string path = Application.dataPath + "/SaveSystem/Logs/Log.txt";

        //Crear archivo revisando que no exista uno anteriormente
        if (!File.Exists(path))
        {
            File.WriteAllText(path, "Log /n/n");
        }
        else
        {
            Debug.Log("A file already exist");
            return;
        }

        //Contenido del archivo
        string content = "Login date: " + System.DateTime.Now + "/n";

        //Agregar la informacion al archivo
        File.AppendAllText(path, content);
    }

    // Start is called before the first frame update
    void Start()
    {
        //CreateFile();
        //SavePosition();
        //GetPosition();

        filePath = Application.dataPath + "/SaveSystem/Logs/Position2.txt";

        //Store the last position of the object (Initial Position)
        lastPos = transform.position;
        m_writer = new StreamWriter(filePath);
    }

    private void Update()
    {
        SavePositionsInMovement();
    }

    public void SavePosition()
    {
        string path = Application.dataPath + "/SaveSystem/Logs/Position.txt";

        if (File.Exists(path))
        {
            File.Delete(path);
        }

        StreamWriter writer = new StreamWriter(path);

        //Set the position of the object in the file
        writer.WriteLine(transform.position.x + ", " + transform.position.y + ", " + transform.position.z);

        //Close StreamWriter
        writer.Close();
    }    

    public void GetPosition()
    {
        string path = Application.dataPath + "/SaveSystem/Logs/Position.txt";
        StreamReader reader = new StreamReader(path);

        string line = reader.ReadLine();
        string[] values = line.Split(", ");

        //Convert string values into position of a new vec3
        Vector3 newPos = new Vector3(float.Parse(values[0]), float.Parse(values[1]), float.Parse(values[2]));

        //Set the new position into the object
        transform.position = newPos;

        //Close reader
        reader.Close();
    }

    public void SavePositionsInMovement()
    {
        //Check if the object has move since the last frame
        if(transform.position != lastPos)
        {
            //Set the position of the object in the file
            m_writer.WriteLine(transform.position.x + ", " + transform.position.y + ", " + transform.position.z);
            Debug.Log("Nueva posición guardada!");

            //Store the current position of the object
            lastPos = transform.position;
        }
    }

    private void OnDestroy()
    {
        if(m_writer != null)
        {
            m_writer.Close();
        }
    }
}
