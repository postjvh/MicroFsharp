﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MFDE.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("MFDE.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to fun nEven n : int -&gt; list =
        ///    if n = 0 then []
        ///    else if n % 2 = 0 then n::nEven(n-1) else nEven(n-1)
        ///end
        ///
        ///fun count lst : list -&gt; int =
        ///    match lst with
        ///    | Nil -&gt; 0
        ///    | Cons(x, xs) -&gt; 1 + (count xs)
        ///    end
        ///end
        ///
        ///let evenNums = nEven 800 in
        ///let length = count evenNums in
        ///do print length in
        ///0.
        /// </summary>
        internal static string Even {
            get {
                return ResourceManager.GetString("Even", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to fun nEven n : int -&gt; list =
        ///    if n = 0 then []
        ///    else if n % 2 = 0 then n::nEven(n-1) else nEven(n-1)
        ///end
        ///
        ///fun count lst : list -&gt; int =
        ///    match lst with
        ///    | Nil -&gt; 0
        ///    | Cons(x, xs) -&gt; 1 + (count xs)
        ///    end
        ///end
        ///
        ///let evenNums = nEven 800 in
        ///let length = count evenNums in
        ///do print length in
        ///0.
        /// </summary>
        internal static string EvenTail {
            get {
                return ResourceManager.GetString("EvenTail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to fun fib a b max : int -&gt; int -&gt; int -&gt; list =
        ///   let next = a + b in
        ///   if a &lt; max then a::(fib b next max) else []
        ///end
        ///
        ///let result = fib 1 2 100 in 
        ///do printList result in
        ///0.
        /// </summary>
        internal static string Fibonacci {
            get {
                return ResourceManager.GetString("Fibonacci", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to fun sumList lst : list -&gt; int = 
        ///    match lst with
        ///    | Nil -&gt; 0
        ///    | Cons(x, rest) -&gt; x + (sumList rest)
        ///    end
        ///end
        ///
        ///let myList = [1; 2; 3; 4; 5; 6; 7; 8; 9; 10] in
        ///let result = sumList myList in
        ///do print result in
        ///0 .
        /// </summary>
        internal static string List {
            get {
                return ResourceManager.GetString("List", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to fun highest x y : int -&gt; int -&gt; int = 
        ///  if x &gt; y then x else y
        ///end
        ///
        ///fun fold f val lst : (int -&gt; int -&gt; int) -&gt; int -&gt; list -&gt; int = 
        ///    match lst with
        ///    | Nil -&gt; val
        ///    | Cons(x, xs) -&gt; fold f (f x val) xs
        ///    end
        ///end
        ///
        ///let myList = [1; 4; 6; -123; 3; 54; 2; 123; 43; 23; 9; 34; 122] in
        ///let result = fold highest 0 myList in
        ///do print result in
        ///0
        ///.
        /// </summary>
        internal static string ListFold {
            get {
                return ResourceManager.GetString("ListFold", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to fun map f lst : (int -&gt; int) -&gt; list -&gt; list =
        ///    match lst with
        ///    | Nil -&gt; []
        ///    | Cons(x, xs) -&gt; f x :: map f xs
        ///    end
        ///end
        ///
        ///fun negate n : int -&gt; int = 
        ///    n * -1
        ///end
        ///
        ///let nums = [1; -2; 3; -4; 5; -6; 7; -8; 9; -10] in
        ///let negatedNums = map negate nums in
        ///do printList negatedNums in
        ///0 .
        /// </summary>
        internal static string ListMap {
            get {
                return ResourceManager.GetString("ListMap", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to fun findBest curBest lowest next : int -&gt; int -&gt; int -&gt; int  = 
        ///    let bestCandidate = next - lowest in
        ///    if bestCandidate &gt; curBest then bestCandidate else curBest
        ///end
        ///
        ///fun maxProfit lowest best lst : int -&gt; int -&gt; list -&gt; int = 
        ///    match lst with
        ///    | Nil -&gt; best
        ///    | Cons(x, xs) -&gt; let newLowest = if x &lt; lowest then x else lowest in
        ///                     let newBest = findBest best lowest x in
        ///                     maxProfit newLowest newBest xs
        ///    end
        ///end
        ///
        ///fun calcMaxProfit lst : list [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string MaxProfitAlgo {
            get {
                return ResourceManager.GetString("MaxProfitAlgo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap mfLogo {
            get {
                object obj = ResourceManager.GetObject("mfLogo", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to fun calcSetCombination set1 set2 set3 : int -&gt; int -&gt; int -&gt; int = 
        ///    set1 * set2 * set3
        ///end
        ///
        ///let students = 50 in
        ///let pizzaTypes = 10 in
        ///let beverageTypes = 5 in
        ///
        ///let studentsBound = calcSetCombination students in
        ///let pizzaStudentsBound = studentsBound pizzaTypes in 
        ///let totalCombinations = pizzaStudentsBound beverageTypes in 
        ///do print totalCombinations in 
        ///0
        ///.
        /// </summary>
        internal static string PartialApplication {
            get {
                return ResourceManager.GetString("PartialApplication", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to fun printListElements lst : list -&gt; int = 
        ///	match lst with
        ///	| Nil -&gt; 0 
        ///	| Cons(x, xs) -&gt; 
        ///		match xs with
        ///		| Nil -&gt; print x
        ///		| Cons(y, ys) -&gt;
        ///			do print x in
        ///			do printAscii 59 in
        ///			do printAscii 32 in
        ///			printListElements xs
        ///		end
        ///	end
        ///end
        ///
        ///fun printList lst : list -&gt; int = 
        ///	do printAscii 91 in
        ///	do printListElements lst in
        ///	do printAscii 93 in
        ///	0
        ///end.
        /// </summary>
        internal static string PrintList {
            get {
                return ResourceManager.GetString("PrintList", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to fun printTree myTree : tree -&gt; int = 
        ///  match myTree with
        ///  | Leaf -&gt; do printAscii 91 in
        ///      printAscii 93
        ///  | Node(x, left, right) -&gt; 
        ///        do printAscii 91 in
        ///        do print x in
        ///        do printTree left in
        ///        do printTree right in
        ///        printAscii 93
        ///  end
        ///end
        ///.
        /// </summary>
        internal static string PrintTree {
            get {
                return ResourceManager.GetString("PrintTree", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to fun addNum newNum binTree : int -&gt; tree -&gt; tree =
        ///    match binTree with 
        ///    | Leaf -&gt; Node(newNum, Leaf, Leaf)
        ///    | Node(val, left, right) -&gt; if newNum &lt; val 
        ///                                then Node(val, (addNum newNum left), right)
        ///                                else Node(val, left, (addNum newNum right))
        ///    end
        ///end
        ///
        ///fun addNums lstNums binTree : list -&gt; tree -&gt; tree = 
        ///    match lstNums with
        ///    | Nil -&gt; binTree
        ///    | Cons(x, xs) -&gt; addNums xs (addNum x binTree)
        ///    end
        ///end
        ///
        ///fun fin [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string SearchTree {
            get {
                return ResourceManager.GetString("SearchTree", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to fun map f binTree : (int -&gt; int) -&gt; tree -&gt; tree =
        ///   match binTree with
        ///   | Leaf -&gt; Leaf
        ///   | Node(x, left, right) -&gt; Node((f x), (map f left), (map f right))
        ///   end
        ///end
        ///
        ///fun square x : int -&gt; int = 
        ///    x * x
        ///end
        ///
        ///let myTree = Node(1, Node(2, Leaf, Leaf), Node(3, Leaf, Leaf)) in
        ///let resultTree = map square myTree in
        ///do printTree resultTree in
        ///0.
        /// </summary>
        internal static string TreeMap {
            get {
                return ResourceManager.GetString("TreeMap", resourceCulture);
            }
        }
    }
}