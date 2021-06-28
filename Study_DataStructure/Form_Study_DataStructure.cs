using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Study_DataStructure {
    public partial class Form_Study_DataStructure : Form {
        public Form_Study_DataStructure() {
            InitializeComponent();
        }
               
        /// <summary> Array (固定類型)(固定長度)
        /// Array, ArrayList, List 本質上都是數組(陣列)
        /// 內存是連續分配的，可以用座標訪問，讀取快，增刪慢
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e) {
            Console.WriteLine("----> 資料結構 [Array] 按鈕開始 <----");
            int[] intArray = new int[10];
            intArray[0] = 87;
            string[] strArray = new string[3] { "1", "22", "333" };
            for (int i = 0; i < strArray.Length; i++) {
                Console.WriteLine(strArray[i]);
            }
            Console.WriteLine("----> 資料結構 [Array] 按鈕結束 <----");
        }

        /// <summary> ArrayList (不固定類型)(不固定長度)
        /// Array, ArrayList, List 本質上都是數組(陣列)
        /// 內存是連續分配的，可以用座標訪問，讀取快，增刪慢
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e) {
            Console.WriteLine("----> 資料結構 [ArrayList] 按鈕開始 <----");

            ArrayList arrayList = new ArrayList();  //宣告時不知道有多長
            arrayList.Add("0-Eleven");  //添加string數據，會增加長度
            arrayList.Add("1-Eric");
            arrayList.Add(2);           //添加int數據，會增加長度
            arrayList.Add(3);
            arrayList.Add(4);
            //arrayList[5] = 26;      //這裡會Runtime error: 索引賦值時，不能增加長度
            //arrayList.RemoveAt(5);  //這裡會Runtime error: 超過範圍
            arrayList.RemoveAt(3);          //刪除數據 by index
            arrayList.Remove("0-Eleven");   //刪除數據 by 內容 (滿足的第一個)
            for (int i = 0; i < arrayList.Count; i++) {
                Console.WriteLine(arrayList[i]);
            }
  
            Console.WriteLine("----> 資料結構 [ArrayList] 按鈕結束 <----");
        }

        /// <summary> List (固定類型)(不固定長度)(最常用)(泛型-避免損失效能)
        /// Array, ArrayList, List 本質上都是數組(陣列)
        /// 內存是連續分配的，可以用座標訪問，讀取快，增刪慢
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e) {
            Console.WriteLine("----> 資料結構 [List] 按鈕開始 <----");
            
            List<int> intList = new List<int>();  //宣告時不知道有多長
            List<string> stringList = new List<string>();  //可以換成各種常用型別
            stringList.Add("0-Eleven");     //添加數據，會增加長度
            stringList.Add("1-Eric");
            stringList.Add("2-Jack");
            stringList.Add("3-Kevin");
            //stringList[4] = "4-Susan";    //這裡會Runtime error: 索引賦值時，不能增加長度
            //stringList.RemoveAt(4);       //這裡會Runtime error: 超過範圍
            stringList.RemoveAt(0);         //刪除數據 by index
            stringList.Remove("2-Jack");  //刪除數據 by 內容 (滿足的第一個)
            for (int i = 0; i < stringList.Count; i++) {
                Console.WriteLine(stringList[i]);
            }

            Console.WriteLine("----> 資料結構 [List] 按鈕結束 <----");
        }

        /// <summary> LinkedList (固定類型)(不固定長度)(鏈表)
        /// LinkedList, Queue, Stack 本質上都是「鏈表」
        /// 內存是非連續分配的，不可以用座標訪問，增刪快，讀取慢
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button6_Click(object sender, EventArgs e) {
            Console.WriteLine("----> 資料結構 [LinkedList] 按鈕開始 <----");

            LinkedList<int> intLinkList = new LinkedList<int>();
            intLinkList.AddFirst(123);
            intLinkList.AddFirst(456);
            intLinkList.AddLast(4);
            intLinkList.AddLast(5);
            intLinkList.AddLast(6);
            intLinkList.AddLast(7);

            bool isContain = intLinkList.Contains(123);  //是否包含某數據
            LinkedListNode<int> node123 = intLinkList.Find(123);   //找到節點
            intLinkList.AddBefore(node123, 1);     //在結點前添加數據    
            intLinkList.AddAfter(node123, 3);      //在結點後添加數據
            intLinkList.AddAfter(node123, 2);      //在結點後添加數據

            intLinkList.Remove(456);
            intLinkList.Remove(node123);
            intLinkList.RemoveFirst();
            intLinkList.RemoveLast();

            //查找不方便，如果不用foreach，就要靠一個一個串接下去查
            foreach (int item in intLinkList) {
                Console.WriteLine(item);
            }
            intLinkList.Clear();

            Console.WriteLine("----> 資料結構 [LinkedList] 按鈕結束 <----");
        }

        /// <summary> Queue (固定類型)(不固定長度)(隊列)(先進先出)
        /// LinkedList, Queue, Stack 本質上都是「鏈表」
        /// 內存是非連續分配的，不可以用座標訪問，增刪快，讀取慢
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e) {
            Console.WriteLine("----> 資料結構 [Queue] 按鈕開始 <----");

            Queue<string> stringQueue = new Queue<string>();  //建立隊伍
            stringQueue.Enqueue("one");     //加入隊伍
            stringQueue.Enqueue("two");
            stringQueue.Enqueue("three");
            stringQueue.Enqueue("four");
            stringQueue.Enqueue("five");

            foreach (string item in stringQueue) {
                Console.WriteLine(item);
            }
            Console.WriteLine("離開隊伍: " + stringQueue.Dequeue());  //先進先出，取出一個 (直接取出)
            Console.WriteLine("下一個要離開隊伍的是: " + stringQueue.Peek());  //先進先出，取出一個 (僅查詢)
            Console.WriteLine("離開隊伍: " + stringQueue.Dequeue());

            //Queue可以轉成數組，也可利用數組建立Queue
            Queue<string> copyQueue = new Queue<string>(stringQueue.ToArray());
            foreach (string item in copyQueue) {
                Console.WriteLine(item);
            }
            Console.WriteLine("隊伍中是否包含four: " + copyQueue.Contains("four"));
            Console.WriteLine("隊伍中有幾個元素: " + copyQueue.Count);
            copyQueue.Clear();

            Console.WriteLine("----> 資料結構 [Queue] 按鈕結束 <----");
        }

        /// <summary> Stack (固定類型)(不固定長度)(棧)(堆疊)(後進先出)
        /// LinkedList, Queue, Stack 本質上都是「鏈表」
        /// 內存是非連續分配的，不可以用座標訪問，增刪快，讀取慢
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e) {
            Console.WriteLine("----> 資料結構 [Stack] 按鈕開始 <----");

            Stack<string> stringStack = new Stack<string>();  //建立堆疊
            stringStack.Push("one");     //加入堆疊
            stringStack.Push("two");
            stringStack.Push("three");
            stringStack.Push("four");
            stringStack.Push("five");

            foreach (string item in stringStack) {
                Console.WriteLine(item);
            }
            Console.WriteLine("離開堆疊: " + stringStack.Pop());  //後進先出，取出一個 (直接取出)
            Console.WriteLine("下一個要離開堆疊的是: " + stringStack.Peek());  //後進先出，取出一個 (僅查詢)
            Console.WriteLine("離開堆疊: " + stringStack.Pop());

            //Stack可以轉成數組，也可利用數組建立Stack
            Stack<string> copyStack = new Stack<string>(stringStack.ToArray());
            foreach (string item in copyStack) {
                Console.WriteLine(item);
            }
            Console.WriteLine("隊伍中是否包含four: " + copyStack.Contains("four"));
            Console.WriteLine("隊伍中有幾個元素: " + copyStack.Count);
            copyStack.Clear();

            Console.WriteLine("----> 資料結構 [Stack] 按鈕結束 <----");
        }

        /// <summary> HashSet (固定類型)(不固定長度)(集合)(去重)(沒有順序)
        /// HashSet, SortedSet 本質上都是「集合」
        /// 不能重複，長度是可以增加的，但不是連續的，沒有座標
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button7_Click(object sender, EventArgs e) {
            Console.WriteLine("----> 資料結構 [HashSet] 按鈕開始 <----");

            //去重，就是HashSet最主要的價值
            HashSet<string> stringHashSet = new HashSet<string>();  //建立集合
            stringHashSet.Add("zero");     // 加入集合
            stringHashSet.Add("one");
            stringHashSet.Add("two");
            stringHashSet.Add("three");
            stringHashSet.Add("three");    // 重複元素，不會加入
            stringHashSet.Add("three");    // 重複元素，不會加入

            foreach (string item in stringHashSet) {
                Console.WriteLine(item);
            }
            Console.WriteLine("集合中是否包含four: " + stringHashSet.Contains("four"));
            Console.WriteLine("集合中有幾個元素: " + stringHashSet.Count);

            //這是另一個集合
            HashSet<string> hashSet_2 = new HashSet<string>();  //建立集合
            hashSet_2.Add("one");
            hashSet_2.Add("two");
            hashSet_2.Add("three");
            hashSet_2.Add("four");
            hashSet_2.Add("five");

            //兩個集合可以完成「交差併補」的操作: 交集/差集/聯集/補集 
            stringHashSet.SymmetricExceptWith(hashSet_2); //補集
            stringHashSet.UnionWith(hashSet_2);           //聯集 (並集)
            stringHashSet.ExceptWith(hashSet_2);          //差集 
            stringHashSet.IntersectWith(hashSet_2);       //交集            
            
            Console.WriteLine("----> 資料結構 [HashSet] 按鈕結束 <----");
        }

        /// <summary> SortedSet (固定類型)(不固定長度)(集合)(去重)(有排序)
        /// HashSet, SortedSet 本質上都是「集合」
        /// 不能重複，長度是可以增加的，但不是連續的，沒有座標
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button8_Click(object sender, EventArgs e) {
            Console.WriteLine("----> 資料結構 [SortedSet] 按鈕開始 <----");

            SortedSet<string> stringSortedSet = new SortedSet<string>();  //建立集合
            stringSortedSet.Add("zero");     // 加入集合
            stringSortedSet.Add("one");
            stringSortedSet.Add("two");
            stringSortedSet.Add("three");
            stringSortedSet.Add("four");
            stringSortedSet.Add("three");    // 重複元素，不會加入
            
            foreach (string item in stringSortedSet) {
                Console.WriteLine(item);
            }
            Console.WriteLine("集合中是否包含four: " + stringSortedSet.Contains("four"));
            Console.WriteLine("集合中有幾個元素: " + stringSortedSet.Count);
            
            Console.WriteLine("----> 資料結構 [SortedSet] 按鈕結束 <----");
        }

        /// <summary> Hashtable (不固定類型)(不固定長度)(哈希表)(資料不按加入順序)(無排序)
        /// <哈希表> <雜湊表> Key-Value 型式
        /// object 類型 --> 需要一定的轉換時間 --> 效能損失
        /// 查找數據時，利用Key一次定位，增刪快，讀取也快！(空間換時間)(數據多效率會下降)
        /// 長度是可以增加的，拿著key計算出一個地址，然後放入key-value    
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button9_Click(object sender, EventArgs e) {
            Console.WriteLine("----> 資料結構 [Hashtable] 按鈕開始 <----");

            Hashtable hashtable = new Hashtable();  //建立哈希表
            hashtable.Add("zero", "0000000000");    //利用Key與Value加入哈希表
            hashtable.Add(1, "111111111");          //Key: 不固定類型
            hashtable.Add("two", 2);                //Value: 不固定類型
            hashtable.Add("3", DateTime.Now);
            hashtable.Add("four", "444");
            //hashtable.Add("four", "555");         //Runtime error: 相同Key不能重複加入
            hashtable.Add("four-2", "444");         //不同Key，相同Value，是可以的

            foreach (DictionaryEntry objDE in hashtable) {
                //一次拿到一對資料，包含一個Key一個Value
                Console.WriteLine(objDE.Key.ToString() + "\t-\t" + objDE.Value.ToString());
            }
            Console.WriteLine("哈希表中是否包含Key=\"four\"的資料: " + hashtable.Contains("four"));
            Console.WriteLine("哈希表中有幾個元素: " + hashtable.Count);

            //線程安全，保證只有一個線程寫數據，其他線程只能讀
            Hashtable mySyncdHT = Hashtable.Synchronized(hashtable);
            Console.WriteLine("hashtable 是不是線程安全的？ {0}", hashtable.IsSynchronized ? "是" : "否");
            Console.WriteLine("mySyncdHT 是不是線程安全的？ {0}", mySyncdHT.IsSynchronized ? "是" : "否");

            Console.WriteLine("----> 資料結構 [Hashtable] 按鈕結束 <----");
        }

        /// <summary> Dictionary (固定類型)(不固定長度)(字典)(資料按加入順序)(無排序)
        /// Key-Value 型式
        /// Dictionary, ConcurrentDictionary(線程安全字典), SortedDictionary
        /// 泛型 --> 效率高
        /// 查找數據時，利用Key一次定位，增刪快，讀取也快！(空間換時間)(數據多效率會下降)
        /// 資料按照加入的順序存放 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button10_Click(object sender, EventArgs e) {
            Console.WriteLine("----> 資料結構 [Dictionary] 按鈕開始 <----");
            
            Dictionary<int, string> dictionary = new Dictionary<int, string>();  //建立字典
            dictionary.Add(1, "Jack");        //利用Key與Value加入字典
            dictionary.Add(5, "Kevin");
            dictionary.Add(3, "Bill");
            dictionary.Add(2, "Pond");
            dictionary.Add(4, "Eric");
            //dictionary.Add(2, "Daniel");    //Runtime error: 相同Key不能重複加入

            foreach (var item in dictionary) {
                Console.WriteLine(item.Key + "\t-\t" + item.Value);
            }
            Console.WriteLine("字典表中是否包含Key=4的資料: " + dictionary.ContainsKey(4));
            Console.WriteLine("字典表中是否包含Value=\"Jimmy\"的資料: " + dictionary.ContainsValue("Jimmy"));
            Console.WriteLine("字典中有幾個元素: " + dictionary.Count);

            //线程安全的字典
            ConcurrentDictionary<int, string> concurrentDictionary =
                new ConcurrentDictionary<int, string>(dictionary);
    
            Console.WriteLine("----> 資料結構 [Dictionary] 按鈕結束 <----");
        }

        /// <summary> SortedDictionary (固定類型)(不固定長度)(字典)(資料按加入順序)(有排序)
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button11_Click(object sender, EventArgs e) {
            Console.WriteLine("----> 資料結構 [SortedDictionary] 按鈕開始 <----");

            SortedDictionary<int, string> sortedDictionary = new SortedDictionary<int, string>();  //建立字典
            sortedDictionary.Add(1, "Jack");        //利用Key與Value加入字典
            sortedDictionary.Add(5, "Kevin");
            sortedDictionary.Add(3, "Bill");
            sortedDictionary.Add(2, "Pond");
            sortedDictionary.Add(4, "Eric");
            //sortedDictionary.Add(2, "Daniel");    //Runtime error: 相同Key不能重複加入

            foreach (var item in sortedDictionary) {
                Console.WriteLine(item.Key + "\t-\t" + item.Value);
            }
            Console.WriteLine("字典表中是否包含Key=4的資料: " + sortedDictionary.ContainsKey(4));
            Console.WriteLine("字典表中是否包含Value=\"Jimmy\"的資料: " + sortedDictionary.ContainsValue("Jimmy"));
            Console.WriteLine("字典中有幾個元素: " + sortedDictionary.Count);                    
 
            Console.WriteLine("----> 資料結構 [SortedDictionary] 按鈕結束 <----");
        }

        // 線程安全版本的集合
        // ConcurrentQueue
        // ConcurrentStack
        // ConcurrentBag
        // ConcurrentDictionary
        // BlockingCollection


        /// <summary> Generic Method 泛型方法
        /// 泛型方法：用一個方法，滿足不同的參數類型，做相同的事
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button12_Click(object sender, EventArgs e) {
            Console.WriteLine("----> 泛型方法 [Generic Method] 按鈕開始 <----");

            Console.WriteLine("----> .net 1.0 沒有泛型，這些是一般方法");
            ShowInt(500);
            ShowString("Jack");
            ShowDateTime(DateTime.Now);
            Console.WriteLine();

            Console.WriteLine("----> .net 1.0 沒有泛型，不過可以傳Object進方法，但有性能損失的問題");
            ShowObject(500);
            ShowObject("Jack");
            ShowObject(DateTime.Now);
            Console.WriteLine();
            
            Console.WriteLine("----> .net 2.0 泛型方法，用一個方法，滿足不同的參數類型，做相同的事");
            Show<int>(500); //<int>可以省略，編譯器自動推算
            Show(500);
            Show("Jack");
            Show(DateTime.Now);
            Console.WriteLine();
            
            Console.WriteLine("----> 泛型方法 [Generic Method] 按鈕結束 <----");
        }

        #region 泛型方法
        private void ShowInt(int iParameter) {
            Console.WriteLine("This is " + MethodBase.GetCurrentMethod().Name +
                              ", paramater type=" + iParameter.GetType().Name +
                              ", value=" + iParameter.ToString());
        }
        private void ShowString(string iParameter) {
            Console.WriteLine("This is " + MethodBase.GetCurrentMethod().Name +
                              ", paramater type=" + iParameter.GetType().Name +
                              ", value=" + iParameter.ToString());
        }
        private void ShowDateTime(DateTime iParameter) {
            Console.WriteLine("This is " + MethodBase.GetCurrentMethod().Name +
                              ", paramater type=" + iParameter.GetType().Name +
                              ", value=" + iParameter.ToString());
        }
        private void ShowObject(Object iParameter) {
            Console.WriteLine("This is " + MethodBase.GetCurrentMethod().Name +
                              ", paramater type=" + iParameter.GetType().Name +
                              ", value=" + iParameter.ToString());
        }

        private void Show<T>(T iParameter)
            // where T : IFormattable  //接口約束
            // where T : class         //引用類型約束
            // where T : struct        //值類型約束
            // where T : new()         //無參數建構子約束
        {
            Console.WriteLine("This is " + MethodBase.GetCurrentMethod().Name +
                              ", paramater type=" + iParameter.GetType().Name +
                              ", value=" + iParameter.ToString());
        }
        #endregion
        
        /// <summary> Generic Class 泛型類
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button13_Click(object sender, EventArgs e) {
            Console.WriteLine("----> 泛型類 [Generic Class] 按鈕開始 <----");

            Console.WriteLine("----> 一般類");
            MyClassInt instance_1 = new MyClassInt(2000);
            MyClassString instance_2 = new MyClassString("Bill");
            MyClassDateTime instance_3 = new MyClassDateTime(DateTime.Now);
            Console.WriteLine();

            Console.WriteLine("----> 泛型類，類型不寫死，Runtime時，用到什麼再補什麼");
            MyGenericClass<int> instance_4 = new MyGenericClass<int>(2000);
            MyGenericClass<string> instance_5 = new MyGenericClass<string>("Jack");
            MyGenericClass<DateTime> instance_6 = new MyGenericClass<DateTime>(DateTime.Now);
            MyGenericClass<MyData> instance_7 = new MyGenericClass<MyData>(
                                                new MyData(2000, "Jack", DateTime.Now));
            Console.WriteLine();

            Console.WriteLine("----> 泛型類 [Generic Class] 按鈕結束 <----");
        }

    }


    // 一般類
    public class MyClassInt {
        public MyClassInt(int iParameter) {
            Console.WriteLine("建立了一個:       " + MethodBase.GetCurrentMethod().DeclaringType.FullName +
                            "\n傳進來的參數型別: " + iParameter.GetType().Name +
                            "\n傳進來的參數值:   " + iParameter.ToString() +
                            "\n--------------------------------------");
        }
    }
    public class MyClassString {
        public MyClassString(string iParameter) {
            Console.WriteLine("建立了一個:       " + MethodBase.GetCurrentMethod().DeclaringType.FullName +
                            "\n傳進來的參數型別: " + iParameter.GetType().Name +
                            "\n傳進來的參數值:   " + iParameter.ToString() +
                            "\n--------------------------------------");
        }
    }
    public class MyClassDateTime {
        public MyClassDateTime(DateTime iParameter) {
            Console.WriteLine("建立了一個:       " + MethodBase.GetCurrentMethod().DeclaringType.FullName +
                            "\n傳進來的參數型別: " + iParameter.GetType().Name +
                            "\n傳進來的參數值:   " + iParameter.ToString() +
                            "\n--------------------------------------");
        }
    }
    public class MyData {
        private int value1;
        private string value2;
        private DateTime value3;
        public MyData(int i, string s, DateTime t) {
            value1 = i;
            value2 = s;
            value3 = t;
        }
        public override string ToString() {
            return value1 + "+" + value2 + "+" + value3;
        }
    }

    // 泛型類
    public class MyGenericClass<T> //where T : MyData  //約束基類
    {
        public MyGenericClass(T iParameter) {
            Console.WriteLine("建立了一個:       " + MethodBase.GetCurrentMethod().DeclaringType.FullName +
                            "\n傳進來的參數型別: " + iParameter.GetType().Name +
                            "\n傳進來的參數值:   " + iParameter.ToString() +
                            "\n--------------------------------------");
        }
    }








}
