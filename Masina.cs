using System;

namespace InchirieriMasini
{
    public class Masina
    {
        public string Marca { get; }
        public string Model { get; }
        public int AnFabricatie { get; }
        public string NumarInmatriculare { get; }

        public Masina(string marca, string model, int anFabricatie, string numarInmatriculare)
        {
            Marca = marca;
            Model = model;
            AnFabricatie = anFabricatie;
            NumarInmatriculare = numarInmatriculare;
        }

        public string Info()
        {
            return $"Masina: {Marca} {Model}, An: {AnFabricatie}, Nr: {NumarInmatriculare}";
        }
    }
}