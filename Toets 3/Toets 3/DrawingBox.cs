using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Toets_3
{
    class DrawingBox
    {
        public List<Shape> Shapes { get; private set; }
        private BinaryFormatter binaryFormatter = new BinaryFormatter();
        public void Add(Shape shape)
        {
            
        }

        public void Remove(Shape shape)
        {
            
        }

        public void DrawAll(Graphics graphics)
        {
            
        }

        public void Save(string fileName)
        {
            #region CheckFile

            CheckFile(fileName);
            if (!File.Exists(fileName))
            {
                File.Delete(fileName);
            }

            #endregion

            using (Stream streamWrite = File.Open(fileName, FileMode.Create))
            {
                binaryFormatter.Serialize(streamWrite, Shapes);
                streamWrite.Close();
            }
        }

        public void Load(string fileName)
        {
            CheckFile(fileName);

            using (Stream streamRead = File.OpenRead(fileName))
            {
                Shapes = binaryFormatter.Deserialize(streamRead) as List<Shape>;
            }
        }

        public void Export(string fileName)
        {
            CheckFile(fileName);
            using (StreamWriter streamWriter = new StreamWriter(fileName))
            {
                foreach (Shape existingShape in Shapes)
                {
                    if (existingShape is Circle)
                    {
                        streamWriter.WriteLine("Circle: "); //toevoegen hoe het weggeschreven wordt
                    }
                    else if (existingShape is Square)
                    {
                        streamWriter.WriteLine("Square: ");
                    }
                }
            }
        }

        private void CheckFile(string fileName)
        {
            if (fileName.Trim().Length <= 0)
            {
                throw new ArgumentOutOfRangeException("the filename does not contain any text");
            }
        }
    }
}
