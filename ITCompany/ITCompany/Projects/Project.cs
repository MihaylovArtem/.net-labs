using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Serialization;
using ITCompany.Computers;
using ITCompany.Employees;
using Newtonsoft.Json;

namespace ITCompany.Projects {
    public class Project<T> : IProject<T> where T : IEmployee<IComputer>
    {

        public string name { get; set; }
        public List<T> participants { get; set; } 
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
        [JsonIgnore]
        [XmlIgnoreAttribute]
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
        }


        public async Task asyncSortWithProg(IProgress<int> progress)
        {
            await Task.Run(() =>
            {
                var lastProg = -1;
                for (var i = 0; i < participants.Count; i++)
                {
                    var min = i;
                    for (var j = i + 1; j < participants.Count; j++)
                    {
                        if (participants[j - 1].name.CompareTo(participants[j].name) < 0)
                        {
                            min = j;
                        }
                    }
                    var tmp = participants[i];
                    participants[i] = participants[min];
                    participants[min] = tmp;

                    var curProg = 100*i/participants.Count;
                    if (curProg != lastProg)
                    {
                        progress.Report(curProg);
                        lastProg = curProg;
                    }
                }
            });
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
