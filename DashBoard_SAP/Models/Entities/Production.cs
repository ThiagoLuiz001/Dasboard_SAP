using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashBoard_SAP.Models.Exceptions;
using DashBoard_SAP.Models.Enums;

namespace DashBoard_SAP.Models.Entities
{
    public sealed class Production
    {
        private double _production;

        public string Product { get; set; }
        public double Capacity { get; set; }
        public double _Production {
            get
            {
                return _production;
            }
        }
        public double Consumption
        {
            get
            {
                return Capacity - _production;
            }

        }
        public EnumStatus Status
        {
            get
            {
                if(Capacity.CompareTo(Consumption) == 0)
                {
                    return EnumStatus.Atingiu_a_Meta;
                }
                if(Capacity.CompareTo(Consumption) == 1)
                {
                    return EnumStatus.Ultrapassou;
                }
                return EnumStatus.Dentro_do_Esperado;
            }
        }
        public DateTime Time { get; set; }
        /// <summary>
        /// Construtor vazio
        /// </summary>
        public Production() 
        {
            Product = string.Empty;
        }

        public Production(string product, double capacity,double consuption, DateTime time)
        {
            Product = product;
            Capacity = capacity;
            _production = consuption;
            Time = time;
        }

        public string _Key()
        {
            return $"{Product}-{Time.ToString("MM/yy")}";
        }
        public override string ToString()
        {
            return $"{Product}|{Capacity}|{Consumption}|{Time}";
        }


        public override int GetHashCode()
        {
            return Product.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if(!(obj is Production))
            {
                throw new ExceptionLogic("Comparação fora do escopo de Production!");
            }
            var other = obj as Production;
            return Product.Equals(other.Product) && Time.ToString("MM/yyyy").Equals(other.Time.ToString("MM/yyyy"));
        }
    }
}
