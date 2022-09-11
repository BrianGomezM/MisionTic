using System;
using veterinaria.App.Dominio;
using veterinaria.App.Persistencia;
namespace veterinaria.App.Consola{
    class Program
    {
        private static IRepositorioGato _repoGato = new RepositorioGato(new Persistencia.AppContexto());
        static void Main(string[] args){
            
            Console.WriteLine("Hello World!");
           AddGato();
        }

        private static void AddGato(){
            var gato = new Gato{
                Nombre = "Pelusa",
                Raza = "Albino",
                Edad = 1,
                Color = "Tigrillo"
            };
            _repoGato.AddGato(gato);
        }
    }
}
