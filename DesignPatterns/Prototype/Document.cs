using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Prototype
{
    class Document : DocumentPrototype
    {
        private readonly string typeDocument;

        public Document(string TypeDocument)
        {
            this.typeDocument = TypeDocument;
        }
        public override DocumentPrototype Clone()
        {
            Console.WriteLine("Document Cloned");
            return MemberwiseClone() as DocumentPrototype;
        }

        public string ShowName()
        {
            return typeDocument;
        } 
    }
}
