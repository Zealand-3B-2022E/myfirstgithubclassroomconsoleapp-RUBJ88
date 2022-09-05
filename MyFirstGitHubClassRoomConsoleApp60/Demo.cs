using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstGitHubClassRoomConsoleApp60
{
    class Demo
    {
        private int _id;
        private string _navn;
        private string _efternavn;
        private int _telefon;

        public Demo(int id, string navn, string efternavn, int telefon)
        {
            _id = id;
            _navn = navn;
            _efternavn = efternavn;
            _telefon = telefon;
        }

        public int id
        {
            get => _id;
            set => _id = value;
        }

        public string navn
        {
            get => _navn;
            set => _navn = value;
        }

        public string efternavn
        {
            get => _efternavn;
            set => _efternavn = value;
        }

        public int telefon
        {
            get => telefon;
            set => telefon = value;        }


        public override string ToString()
        {
            return $"{nameof(_id)}: {_id}, {nameof(_navn)}: {_navn}, {nameof(_efternavn)}: {_efternavn} {nameof(_telefon)}{_telefon}";
        }

    }
}
