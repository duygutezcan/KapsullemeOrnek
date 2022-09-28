using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KapsullemeOrnek
{
    public class Personel
    {
        private string tckimlikno;
        public string TCKİMLİKNO
        {
            get 
            {
                return tckimlikno.Substring(0,5)+"******";
            }
            set
            {
                bool kontrol = false;

                if(value.Length == 11)
                {
                    for(int i=0; i<value.Length; i++)
                    {
                       bool sayiMi = char.IsNumber(value[i]); //123456789 
                        if(sayiMi)
                        {
                            //yapmam gereken birşey yok
                        }
                        else
                        {
                            kontrol = true;
                            break;
                        }
                    }
                    if(kontrol)
                    {
                        Console.WriteLine("tc de geçersiz karakter var");
                    }
                    else
                    {
                        tckimlikno = value;
                    }
                  
                }
                else
                {
                    Console.WriteLine("girdiğiniz tc 11 karakter değil");
                }
            }
        }
    }
}
