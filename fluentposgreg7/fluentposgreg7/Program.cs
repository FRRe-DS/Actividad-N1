using System;
using fluentposgreg7.mapeo;
using fluentposgreg7.entidades;
namespace fluentposgreg7
{
    class Program
    {
        static void Main(string[] args)
        {
            // antes en una base de datos posgre crea una base de datos catastro y ahi la tabla con el siguiente 
            // scripts, en el string de conexion cambiar por la clave que pusieron

            //create table usuarios(
            //    id serial not null primary key,
            //    nome varchar(100),
            //    login varchar(50),
            //    senha varchar(50),
            //    status char(1)
            //    )


            UsuarioRepositorio u = new UsuarioRepositorio();
            Usuario p = new Usuario();
           
            p.Nome = "diego";
            p.Login = "aguilera";
            p.Senha = "pw123";
            p.Status = 'a';
            u.Inserir(p);
            Console.WriteLine(u.Consultar());
            Console.ReadLine();

        }
    }
}
