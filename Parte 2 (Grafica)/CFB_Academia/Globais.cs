using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFB_Academia
{
    internal class Globais
    {
        public static string versao="1.0";
        public static Boolean logado=false;
        public static int nivel=0; //0=Comum, 1= Gerente, 2=Master
        public static string caminho = System.Environment.CurrentDirectory;
        public static string nomeBanco = "bd_academia.db";
        public static string caminhoBanco = caminho + @"\sqlite\";

        /*
            N_IDUSUARIO
            T_NOMEUSUARIO
            T_USERNAME
            T_SENHAUSUARIO
            T_STATUSUSUARIO
            N_NIVELUSUARIO
         */
    }
}
