using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SturcutTask
{
    internal class CustomList<T>
    {
        private T[] _arr;
       
        public CustomList(params T[] nums)
        {
            _arr = nums;
        }
        private int Length
        {
            get
            {
                return _arr.Length;
            }
        }

        public int Count
        {
            get
            {
                return _arr.Length;
            }
        }

        public T this[int index]
        {
            get
            {
                if (index >= _arr.Length)
                {
                    return _arr[_arr.Length - 1];
                }
                
                return _arr[index];
            }

            set
            {

                if (index < _arr.Length)
                {

                _arr[index] = value;
                }
            }
        }

        public void Add(T num)
        {
            Array.Resize(ref _arr, _arr.Length + 1);
            _arr[_arr.Length - 1] = num;
            Console.WriteLine($"{num}  elave olundu");
        }

        public void AddRange(params T[] nums)
        {
            int oldLength = _arr.Length;
            Array.Resize(ref _arr, _arr.Length + nums.Length);

            for (int i = 0; i < nums.Length; i++)
            {
                _arr[oldLength + i] = nums[i];
                Console.WriteLine(nums[i] +" elave olundu");
                
            }
        }

        public bool Containts(T num)
        {
            for (int i = 0; i < _arr.Length; i++)
            {
                if (num.Equals(_arr[i]))
                {
                    Console.WriteLine($"{num}  tapıldı");
                    return true;
                }
               
            }
            Console.WriteLine("  tapılmadı");
            return false;
               
        }
        public void Sum()
        {
            if (typeof(T) == typeof(int) || typeof(T) == typeof(decimal) || typeof(T) == typeof(double) || typeof(T) == typeof(long))
            {

                int sum = 0;
                for (int i = 0; i < _arr.Length; i++)
                {
                    sum += Convert.ToInt32(_arr[i]);
                }
                Console.WriteLine($"cem: {sum}");

            }
            else
            {
                Console.WriteLine("bu method ancaq ededlerle islene biler ");
            }
        }
        public void Remove(T num)
        {
            int j = 0;
            
            T[] newArr = new T[_arr.Length - 1];

            for (int i = 0; i < _arr.Length; i++)
            {
                if (_arr[i].Equals(num))
                {
                  
                    continue;

                }
                if (j < _arr.Length)
                {
                    newArr[j] = _arr[i];
                    j++;
                }
            }
            _arr = newArr;
            Console.WriteLine($"{num}  silindi");


        }


        public void RemoveRange(params T[] nums)
        {
            int j = 0;

            T[] newArr = new T[_arr.Length - nums.Length];

            for (int i = 0; i < _arr.Length; i++)
            {

                bool shouldRemove = false;


                for (int k = 0; k < nums.Length; k++)
                {
                    if (_arr[i].Equals(nums[k]))
                    {
                        shouldRemove = true;

                        break;
                    }
                }


                if (!shouldRemove)
                {
                    newArr[j] = _arr[i];
                    j++;
                }
            }

           
            _arr = newArr;
        }
        public override string ToString()
        {
            string res = "";
            for (int i = 0; i < _arr.Length; i++)
            {
                res += _arr[i];


                if (i < _arr.Length - 1)
                {
                    res += ", ";
                }
            }

            return res;
        }



    }
}
    

