using System;

namespace Practice_2.Task_2
{

        class Organization
        {
            private string _name = "";
            private string _product = "";
            public string Name
            {
                get { return _name; }
                set { _name = value; }
            }
            public string Product
            {
                get { return _product; }
                set { _product = value; }
            }
            public void Print()
            {
                Console.WriteLine($"название организации:  {Name}, продукт организации:  {Product}");
            }
        }
        class InsuranceCompany : Organization
        {
            public InsuranceCompany()
            {
                this.Name = "Страховая компания";
                this.Product = "Страховка";
            }
        }
        class OilAndGasCompany : Organization
        {
            public OilAndGasCompany()
            {
                this.Name = "Нефтегазовая компания";
                this.Product = "Нефть и газ";
            }
        }
        class Factory : Organization
        {
            public Factory()
            {
                this.Name = "завод";
                this.Product = "салфетки";
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                InsuranceCompany insurance = new InsuranceCompany();
                insurance.Print();
                OilAndGasCompany oilGas = new OilAndGasCompany();
                oilGas.Print();
                Factory factory = new Factory();
                factory.Print();
            }
        }
    }
