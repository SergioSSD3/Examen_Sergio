
using System;


//namespace EDexamenT6a8


namespace Deposito
{
    /// <summary>
    /// Clase que representa la gestión de los depósitos de una granja.
    ///Tiene dos depósitos: pienso y agua.
    ///La propiedad devuelve el nivel de agua y pienso.
    ///Los métodos permiten reponer o consumir tanto pienso como agua.
    ///Estos comentarios se deben eliminar y usar comentarios de documentación en su lugar.
    /// </summary>

    class Deposito
    {

        //Refactorizacion de las variables en estilo caMel.

        /// <summary>
        /// <param name="nivelAgua"></param>
        /// </summary>
        private decimal nivelAgua;

        /// <summary>
        /// <param name="nivelPienso"></param>
        /// </summary>
        private decimal nivelPienso;

        /// <summary>
        /// <param name="maxAgua"></param>
        /// </summary>
        private decimal maxAgua;

        /// <summary>
        /// <param name="maxPienso"></param>
        /// </summary>
        private decimal maxPienso;


        public decimal levelAgua
        {
            get { return nivelAgua; }
        }

        public decimal levelPienso
        {
            get { return nivelPienso; }
        }

        /// <summary>
        /// Nos proporciona la cantidad de agua disponible
        /// </summary>
        /// <param name="reponerAgua"></param>

        public void reponerAgua(decimal reponerAgua)
        {
            maxAgua = reponerAgua + nivelAgua;
            if (reponerAgua > 0 && maxAgua < 10000) ;

            nivelAgua = nivelAgua + reponerAgua;

        }

    }

    /// <summary>
    /// Nos proporciona la cantidad de pienso disponible
    /// </summary>
    /// <param name="reponerPienso"></param>
    /// 

    public void reponerPienso(decimal reponerPienso)
    {

        maxPienso = reponerPienso + nivelPienso;
        if (reponerPienso > 0 && maxPienso < 5000)
            nivelPienso = nivelPienso + reponerPienso;
    }

    /// <summary>
    /// Nos proporciona la cantidad de pienso disponible
    /// </summary>
    /// <param name="consumoAgua"></param>
    /// 

    public decimal consumoAgua(decimal consumoAgua)
    {
        decimal aguaRetirada = 0;
        if (consumoAgua > 0 && consumoAgua <= nivelAgua)
        {
            aguaRetirada = consumoAgua;
            nivelAgua = nivelAgua - consumoAgua;
        }

        return aguaRetirada;
    }

    /// <summary>
    /// Nos proporciona la cantidad de pienso disponible
    /// </summary>
    /// <param name="consumoPienso"></param>
    /// 

    public decimal consumoPienso(decimal consumoPienso)
    {
        decimal piensoRetirado = 0; 
        if (consumoPienso > 0 && consumoPienso <= nivelPienso)
        {
            piensoRetirado = consumoPienso;
            nivelPienso = nivelPienso - consumoPienso;
        }
        return piensoRetirado;
    }








}
}