using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
namespace prjTask2
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Creating List

            Collection<Element> sortedElements = new Collection<Element>();
            sortedElements.Add(new Element()
            {
                age = 23,
                num = 1,
                name = "Luis"
            });
            sortedElements.Add(new Element()
            {
                age = 19,
                num = 1,
                name = "Luis"
            });

            sortedElements.Add(new Element()
            {
                age = 25,
                num = 2,
                name = "Kasia"
            });
            sortedElements.Add(new Element()
            {
                age = 24,
                num = 2,
                name = "Klaudia"
            });

            sortedElements.Add(new Element()
            {
                age = 23,
                num = 3,
                name = "Pietra"
            });

            #endregion

            Collection<Element> uniqueElements = GetUniqueElementsByNumAndAgeGreaterThan20(sortedElements);
            foreach (Element itemElement in uniqueElements)
            {
                Console.WriteLine($"Num: {itemElement.num} - Name: '{itemElement.name}' - Age: {itemElement.age}");
            }

            Console.Read();
        }

        public static Collection<Element> GetUniqueElementsByNumAndAgeGreaterThan20(Collection<Element> sortedElements)
        {
            Collection<Element> uniqueElements = new Collection<Element>();
            foreach (Element element in sortedElements.Where(x => x.age > 20)) // Getting only elements where age is greater than 20
            {
                if (uniqueElements.FirstOrDefault(x => x.num.Equals(element.num)) == null) // checking if there is an element with the sane 'num'
                {
                    //If no element was found, than add to the result list.
                    uniqueElements.Add(element);
                }
            }
            return uniqueElements;
        }
    }
}
