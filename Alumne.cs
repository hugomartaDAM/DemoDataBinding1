using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDataBinding1
{
    internal class Alumne
    {
        public string Nom { get; set; }
        public string Cognoms { get; set; }
        public string Email { get; set; }
        public DateTime Data_naixement {  get; set; }
        private bool _Horari_mati;
        private bool _Horari_tarda;

        public bool Horari_mati
        {
            get => _Horari_mati;
            set
            {
                _Horari_mati = value;
                _Horari_tarda = !value;
            }
        }
        public bool Horari_tarda
        {
            get => _Horari_tarda;
            set
            {
                _Horari_mati = !value;
                _Horari_tarda = value;
            }
        }

        public bool Curset1 { get; set; }
        public bool Curset2 { get; set; }
        public bool Curset3 { get; set; }

        public Alumne(string nom, string cognoms, string email, DateTime dataNaixement, bool horariMati, bool curset1, bool curset2, bool curset3)
        {
            Nom = nom;
            Cognoms = cognoms;
            Email = email;
            Data_naixement = dataNaixement;
            Horari_mati = horariMati;
            Horari_tarda = !horariMati;
            Curset1 = curset1;
            Curset2 = curset2;
            Curset3 = curset3;
        }
        // Constructor vacío
        public Alumne()
        {
            // Inicializa todas las propiedades con valores por defecto o vacíos
            Nom = "";
            Cognoms = "";
            Email = "";
            Data_naixement = DateTime.Today;
            Horari_mati = false;
            Horari_tarda = false;
            Curset1 = false;
            Curset2 = false;
            Curset3 = false;
        }

    }
}
