using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Lab1.Computers;
using Lab1.Employees;

namespace Lab1.Projects {
    public class Project<T> : IProject<T> where T : IEmployee<IComputer>
    {

        public string name { get; private set; }
        public List<T> participants { get; private set; } 
        public Project(string Name)
        {
           name = Name;
           participants = new List<T>();
        }

        public Project(string Name, List<T> Participants)
        {
            name = Name;
            participants = Participants;
        }

        public void Add(T item)
        {
            participants.Add(item);
        }

        public void Clear()
        {
            participants.Clear();
        }

        public bool Contains(T item)
        {
            return participants.Contains(item);
        }

        public void CopyTo(T[] array, int indexArray)
        {
            participants.CopyTo(array, indexArray);
        }

        public bool Remove(T item)
        {
            return participants.Remove(item);
        }

        public int Count
        {
            get
            {
                return participants.Count;
            }
        }

        public void sortTeam(String fieldToSort)
        {
            if (fieldToSort == "name")
            {
                participants.Sort(delegate(T x, T y)
                {
                    if (x.name == null && y.name == null) return 0;
                    if (x.name == null) return -1;
                    if (y.name == null) return 1;
                    return x.name.CompareTo(y.name);
                });
            }
            else
            {
                Console.WriteLine("Unknown class field");
            }

        }

        public void customSortTeam(Func<T, T, bool> res)
        {
            bool sortIncompleted = true;
            do
            {
                sortIncompleted = false;
                for (int i = 0; i < participants.Count() - 1; i++)
                {
                    if (res(participants[i], participants[i + 1]))
                    {
                        T temp = participants[i];
                        participants[i] = participants[i + 1];
                        participants[i + 1] = temp;
                        sortIncompleted = true;
                    }
                }
            } while (sortIncompleted);
        }

        public void printProjectTeam()
        {
            foreach (T participant in getProjectTeam())
            {
                Console.WriteLine(participant.name + "\n");
            }
        }

        private IEnumerable getProjectTeam()
        {
            for (var i = 0; i < participants.Count; i++)
            {
                yield return participants[i];
            }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new ProjectEnumerator<T>(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new ProjectEnumerator<T>(this);
        } 

    }
}
