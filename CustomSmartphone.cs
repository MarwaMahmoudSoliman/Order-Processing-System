 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone
{
    public class CustomSmartphone
    {
        public string Model { get; set; }
        public string Processor { get; set; }
        public int RAM { get; set; }
        public int Storage { get; set; }
        public List<string> Accessories { get; set; } = new List<string>();

        public override string ToString()
        {
            return $"Model: {Model}, Processor: {Processor}, RAM: {RAM}GB, Storage: {Storage}GB, Accessories: {string.Join(", ", Accessories)}";
        }
    }

    public class SmartphoneBuilder
    {
        private CustomSmartphone phone = new CustomSmartphone();

        public SmartphoneBuilder SetModel(string model)
        {
            phone.Model = model;
            return this;
        }

        public SmartphoneBuilder SetProcessor(string processor)
        {
            phone.Processor = processor;
            return this;
        }

        public SmartphoneBuilder SetRAM(int ram)
        {
            phone.RAM = ram;
            return this;
        }

        public SmartphoneBuilder SetStorage(int storage)
        {
            phone.Storage = storage;
            return this;
        }

        public SmartphoneBuilder AddAccessory(string accessory)
        {
            phone.Accessories.Add(accessory);
            return this;
        }

        public CustomSmartphone Build()
        {
            return phone;
        }
    }

}
