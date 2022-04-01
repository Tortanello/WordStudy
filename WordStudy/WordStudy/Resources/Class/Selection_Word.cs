using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WordStudy.Resources.Class
{
    public class Selection_Word
    {
        public static int[] Selection_Word_metod(string letter, string lang, string lang_trinslated)
        {
            var date = App.Database.GetItems();
            int[] massiv_date_one = new int[date.Count()];
            int[] massiv_date_two;
            int[] massiv_date_three;
            int count = 0;
            int count_2 = 0;
            //  Изменить направление с языка на слова
            if (letter != null)
            {

                if (letter.Length != 1)
                {
                    for (int i = 0; i < date.Count(); i++)
                    {
                        char[] word_for = date.ElementAt(i).Word.ToCharArray();
                        string fill_word = "";
                        try
                        {
                            for (int c = 0; c < letter.Length; c++)
                            {
                                fill_word += word_for[c];
                            }
                        }
                        catch (IndexOutOfRangeException)
                        {

                        }

                        try
                        {
                            if (letter.ToUpper() == fill_word.ToUpper())
                            {
                                // Подходящий элемент в массиве
                                massiv_date_one[i] = i;
                                count++;
                            }
                            else
                            {
                                massiv_date_one[i] = -1;
                            }
                        }
                        catch
                        {
                            massiv_date_one[i] = -1;
                        }
                    }
                }

                else
                {
                    for (int i = 0; i < date.Count(); i++)
                    {
                        try
                        {
                            if (letter.ToUpper() == date.ElementAt(i).Word.First().ToString().ToUpper())
                            {
                                // Подходящий элемент в массиве
                                massiv_date_one[i] = i;
                                count++;
                            }
                            else
                            {
                                massiv_date_one[i] = -1;
                            }
                        }
                        catch
                        {
                            massiv_date_one[i] = -1;
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < date.Count(); i++)
                {
                    massiv_date_one[i] = i;
                    count++;
                }
            }
            massiv_date_two = new int[date.Count()];
            if (lang != "")
            {
                for (int i = 0; i < massiv_date_one.Length; i++)
                {
                    try
                    {
                        if (massiv_date_one[i] != -1 && lang == date.ElementAt(massiv_date_one[i]).Language)
                        {
                            // Подходящий элемент в массиве
                            // Остаются нули
                            massiv_date_two[i] = massiv_date_one[i];
                            count_2++;
                        }
                        else
                        {
                            massiv_date_two[i] = -1;
                        }
                    }
                    catch
                    {
                        massiv_date_two[i] = -1;
                    }
                }
            }
            else
            {
                for (int i = 0; i < massiv_date_one.Length; i++)
                {
                    massiv_date_two[i] = massiv_date_one[i];
                    count_2++;
                }
            }

            massiv_date_three = new int[date.Count()];
            if (lang_trinslated != "")
            {
                for (int i = 0; i < massiv_date_two.Length; i++)
                {
                    // Нету системы защиты от того что в слове просто не будет этих данных
                    try
                    {
                        if (massiv_date_one[i] != -1 && lang_trinslated == date.ElementAt(massiv_date_two[i]).Language_Translated)
                        {
                            // Подходящий элемент в массиве
                            // Все id
                            massiv_date_three[i] = massiv_date_two[i];
                            // Мы получили интовый массив с айди
                        }
                        else
                        {
                            massiv_date_three[i] = -1;
                        }
                    }
                    catch 
                    {
                        massiv_date_three[i] = -1;
                    }
                }
            }
            else
            {
                for (int i = 0; i < massiv_date_two.Length; i++)
                {
                    massiv_date_three[i] = massiv_date_two[i];
                }
            }

            return massiv_date_three;
        }

        public static int[] Count_not_zero (int[] array)
        {
            int[] amount;
            int amount_for_array = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array.ElementAt(i) != -1)
                {
                    amount_for_array++;
                }
            }
            amount = new int[amount_for_array];
            for (int i = 0, z = 0; i < array.Length; i++)
            {
                if (array.ElementAt(i) != -1)
                {
                    amount[z] = array.ElementAt(i);
                    z++;
                }
            }
            return amount;
        }
    }
}
