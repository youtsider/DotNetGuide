﻿using HelloDotNetGuide.常见算法;
using HelloDotNetGuide.数组相关;

namespace HelloDotNetGuide
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("欢迎来到DotNetGuide练习空间！！！");

            #region 常见算法

            希尔排序算法.ShellSortRun();
            //插入排序算法.InsertionSortRun();
            //快速排序算法.QuickSortRun();
            //冒泡排序算法.RecursiveBubbleSortRun();
            //List集合相关算法.GetAfterRemoveListData();
            //选择排序算法.SelectionSortAlgorithmMain();

            #endregion

            #region 数组相关

            //ArrayDeduplication.LoopTraversalDuplicate();

            #endregion
        }
    }
}