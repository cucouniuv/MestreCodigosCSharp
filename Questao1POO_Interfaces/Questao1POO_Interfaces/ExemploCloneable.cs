using System;
using System.Collections.Generic;
using System.Text;

namespace Questao1POO_Interfaces
{
    class Motor
    {
        public string Nome { get; set; }
    }

    class Carro: ICloneable
    {
        public string Nome { get; set; }
        public string Modelo { get; set; }

        public Motor MotorObjeto = new Motor();

        public Carro() { }

        public Carro(Carro carro)
        {
            this.Nome = carro.Nome;
            this.Modelo = carro.Modelo;
        }

        /* Esta interface contém o método Clone que dá suporte à clonagem além do que é fornecido pelo método Object.
         * MemberwiseClone que cria uma cópia superficial de Object atual.
         * O conceito de clonagem de objetos pode ter duas implementações:
         *   Shallow (superficial): Clona o objeto mas copia apenas as referências para os objetos que referencia, 
         *   exceção feita para os tipos por valor (value types) cujos valores são, por definição, sempre copiados.
         *   Deep (profunda): Clona o objeto e todos os objetos por ele referenciados.
         */

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public object DeepClone()
        {
            Carro carro = (Carro)this.MemberwiseClone();

            Motor motor = new Motor();
            motor.Nome = this.MotorObjeto.Nome;

            carro.MotorObjeto = motor;
            return carro;
        }

        //https://docs.microsoft.com/pt-br/dotnet/api/system.object.memberwiseclone?view=netcore-3.1
    }
}
