using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Databases
{
    /// <summary>
    /// Represents a simple database that stores
    /// arrays of objects of the specified type.
    /// </summary>
    /// <typeparam name="TObject">
    /// Type of the objects to store.
    /// </typeparam>
    public class SimpleDatabase<TObject>
    {
        // Cannot mark as static as the class is not static.
        readonly XmlSerializer m_serializer;
        readonly List<TObject> m_data;
        readonly string m_filename;

        /// <summary>
        /// Gets the list of objects inside the database.
        /// </summary>
        public List<TObject> Data
        {
            get { return m_data; }
        }

        /// <summary>
        /// Initializes a new instance of <see cref="Databases.SimpleDatabase"/> class.
        /// </summary>
        /// <param name="filename">
        /// Name of the file to use as storage.
        /// </param>
        public SimpleDatabase(string filename)
        {
            m_serializer = new XmlSerializer(typeof(TObject[]));
            m_data = new List<TObject>();
            m_filename = filename;
        }

        /// <summary>
        /// Loads the database from the storage.
        /// </summary>
        public void Load()
        {
            // Clear the database to stay clean in case of load failure.
            m_data.Clear();

            // Load file into memory to speed-up xml reading operations.
            var data = File.ReadAllBytes(m_filename);

            // Deserialize the array of objects.
            TObject[] objects;
            using (var stream = new MemoryStream(data))
                objects = (TObject[])m_serializer.Deserialize(stream);

            // Push the objects into the runtime storage.
            m_data.AddRange(objects);
        }

        /// <summary>
        /// Saves the database to the storage.
        /// </summary>
        public void Save()
        {
            byte[] data;

            // Serialize into memory to speed-up xml writing operations.
            using (var stream = new MemoryStream())
            {
                m_serializer.Serialize(stream, m_data.ToArray());

                // Store the data inside a byte array.
                data = stream.ToArray();
            }

            // Store all data inside the file.
            File.WriteAllBytes(m_filename, data);
        }
    }
}
