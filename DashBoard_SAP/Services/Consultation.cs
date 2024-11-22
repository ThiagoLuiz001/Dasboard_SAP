﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashBoard_SAP.Models.Entities;

namespace DashBoard_SAP.Services
{
    public static class Consultation
    {
        /// <summary>
        /// Confere se há algum erro dentro do arquivo
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static Dictionary<string,Production> ConferProductionFile(HashSet<Production> list)
        {
            var confer =new Dictionary<string,Production>();
            foreach (var prod in list)
            {
                if (confer.ContainsKey($"{prod._Key}"))
                {
                    DialogResult result = MessageBox.Show($"Deseja substituir a capacidade do {prod.Product} ({prod.Time.ToString("MM/yy")} de consumo:{confer[$"prod._Key"].Capacity} para a capacidade; {prod.Capacity}", $"ALTERAR VALOR DE {prod.Product.ToUpper()}?", MessageBoxButtons.YesNoCancel);
                    if(result == DialogResult.Yes)
                    {
                        confer[$"{prod._Key}"].Capacity = prod.Capacity;
                        MessageBox.Show("VALOR ALTERADO!");
                    }
                    else
                    {
                        MessageBox.Show("VALOR MANTIDO!");
                    }
                }
                else
                {
                    confer.Add($"{prod._Key}", prod);
                }
            }
            return confer;
        }
    
    }
}
