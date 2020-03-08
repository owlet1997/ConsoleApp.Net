using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class Polynom
    {
        private SortedList<int, int> polynom;

        public SortedList<int, int> P => polynom;

        public Polynom()
        {
            polynom = new SortedList<int, int>();
        }

        public Polynom(int n,int maxGrade)
        {
            this.polynom = GeneratePolynom(n, maxGrade);
        }

        public void addNom(int grade, int value)
        {
            P.Add(grade,value);
        }

        public Polynom Summary(Polynom polynomial, string sign)
        {
            Polynom result = new Polynom();

            foreach (var a in this.P)
            {
                switch (sign)
                    {
                        case "+": 
                            result.addNom(a.Key, a.Value+polynomial.P.GetValueOrDefault(a.Key));
                            break;
                        case "-":
                            result.addNom(a.Key, a.Value-polynomial.P.GetValueOrDefault(a.Key));
                            break;
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
                    if (result.P.ContainsKey(a.Key + b.Key))
                    {
                        var temp = result.P.GetValueOrDefault(a.Key + b.Key);
                        result.P.Remove(a.Key + b.Key);
                        result.addNom(a.Key+b.Key,a.Value*b.Value + temp);
                    }
                    else
                    {
                        result.addNom(a.Key+b.Key,a.Value*b.Value);
                    }
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
               if (a.Value!= 0)
               {
                    builder.Append(a.Value);
                    builder.Append("x^");
                    builder.Append(a.Key);
                    count++;
                    if (count!=P.Count)
                       builder.Append(" + ");
               }
           }

           if (builder.Length <= 0) return "Пустой многочлен";
           
           builder.Remove(builder.Length - 3, 3);
           return builder.ToString();

        }
        
        public SortedList<int, int> GeneratePolynom(int size, int maxGrade)
        {
            SortedList<int,int> list = new SortedList<int, int>();
            for (int i = 0; i < size; i++)
            {
                list.Add(i+1, (i+1)*5);
            }
            
            for (int i = 0; i <= maxGrade; i++)
            {
                if (!list.ContainsKey(i))
                    list.Add(i,0);
            }
            return list;
        }
    }
}