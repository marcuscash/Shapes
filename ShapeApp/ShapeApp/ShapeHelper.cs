using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace ShapeApp
{

     public static class ShapeHelper
     {
         public static void SerializeToXml(List<Shape> list, string fileName)
         {
            
            XmlSerializer serializer = new XmlSerializer(list.GetType());
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                serializer.Serialize(writer, list);
            }
        }

        public static void SerializeToJson(List<Shape> list, string fileName)
        {
            using FileStream createStream = File.Create(fileName);
            JsonSerializer.SerializeAsync(createStream, list);
            createStream.DisposeAsync();
        }

        public static void PrintShapes(List<Shape> Shapes)
        {
            foreach (Shape s in Shapes)
            {
                Console.WriteLine("Name: {0:0.00} Area: {1:0.00} Perimeter {2:0.00} Instances: {3} Total Shape Instances: {4}",
                                   s.Name, s.Area, s.Perimeter, s.Count, s.TotalCount);
            }
        }
}

}
