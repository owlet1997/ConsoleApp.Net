using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class Polynom
    {
        private SortedDictionary<int, int> polynom;

        public SortedDictionary<int, int> P => polynom;

        public Polynom()
        {
            polynom = new SortedDictionary<int, int>();
        }

        public void setPolynom(SortedDictionary<int, int> map)
        {
            polynom = map;
        }

        public void addNom(int grade, int value)
        {
            P.Add(grade,value);
        }

        public Polynom Summary(Polynom polynomial, string sign)
        {
            Polynom result = new Polynom();
            
            SortedDictionary<int,int> maxPolynom = new SortedDictionary<int, int>();
            SortedDictionary<int,int> minPolynom = new SortedDictionary<int, int>();
            
            if (this.P.Count >= polynomial.P.Count)
            {
                maxPolynom = this.P.Reverse() as SortedDictionary<int, int>;
                minPolynom = polynomial.P.Reverse() as SortedDictionary<int, int>;
            }
            else
            {
                maxPolynom = polynomial.P.Reverse() as SortedDictionary<int, int>;
                minPolynom = this.P.Reverse() as SortedDictionary<int, int>;
            }

            foreach (var a in maxPolynom)
            {
                if (minPolynom.ContainsKey(a.Key))
                {
                    switch (sign)
                    {
                        case "+": 
                            result.addNom(a.Key, a.Value+minPolynom.GetValueOrDefault(a.Key));
                            break;
                        case "-":
                            result.addNom(a.Key, a.Value-minPolynom.GetValueOrDefault(a.Key));
                            break;
                    }
                }
                else
                {
                    result.addNom(a.Key,a.Value);
                }
            }
            return result;
        }

        public Polynom MultiplyBySingle(int grade, int value)
        {
            Polynom result = new Polynom();
            foreach (var a in this.P)
            {
                result.addNom(a.Key+grade,a.Value*value);
            }
            return result;
        }

        public Polynom MultiplyByPolynom(Polynom polynomial)
        {
            Polynom result = new Polynom();

            foreach (var a in this.P)
            {
                foreach (var b in polynomial.P)
                {
                    result.addNom(a.Key+b.Key,a.Value*b.Value);
                }
            }

            return result;
        }
        
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            var count = 0;
            foreach (var a in P)
            {
                if (a.Key != 0)
                {
                    builder.Append(a.Value);
                    builder.Append("x^");
                    builder.Append(a.Key);
                    count++;
                    if (count!=P.Count)
                    builder.Append(" + ");
                }
            }

            return builder.ToString();
        }
    }
}