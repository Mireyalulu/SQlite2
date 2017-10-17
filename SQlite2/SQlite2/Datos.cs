using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace SQlite2
{
    public class Datos
    {
        string id;
        string dto1;
        string dto2;
        string dto3;
        string dto4;
        string dto5;
        string dto6;
        string dto7;
        string dto8;
        string dto9;

        [PrimaryKey, Unique, MaxLength(5)]

        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        [Column("Nombre"), MaxLength(20)]

        public string Dto1
        {
            get { return dto1; }
            set { dto1 = value; }
        }
        [Column("Apellido"), MaxLength(20)]

        public string Dto2
        {
            get { return dto2; }
            set { dto2 = value; }
        }
        [Column("Direccion"), MaxLength(20)]

        public string Dto3
        {
            get { return dto3; }
            set { dto3 = value; }
        }
        [Column("Telefono"), MaxLength(20)]

        public string Dto4
        {
            get { return dto4; }
            set { dto4 = value; }
        }
        [Column("Carrera"), MaxLength(20)]

        public string Dto5
        {
            get { return dto5; }
            set { dto5 = value; }
        }
        [Column("Semestre"), MaxLength(20)]

        public string Dto6
        {
            get { return dto6; }
            set { dto6 = value; }
        }
        [Column("Matricula"), MaxLength(20)]

        public string Dto7
        {
            get { return dto7; }
            set { dto7 = value; }
        }
        [Column("Correo"), MaxLength(20)]

        public string Dto8
        {
            get { return dto8; }
            set { dto8 = value; }
        }
        [Column("Github"), MaxLength(20)]

        public string Dto9
        {
            get { return dto9; }
            set { dto9 = value; }
        }




    }
}
