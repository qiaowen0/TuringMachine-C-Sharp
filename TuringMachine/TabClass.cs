using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuringMachine
{
    class JmpTab
    {
        public char read;
        public char write;
        public int direction;
        public int statue;
        public JmpTab next;
        public JmpTab()
        {
            next = null;
        }
    }


    public class TabClass
    {
        private int length;
        private string[] statueTabs;    //状态符号串表
        string[] Jmpfuncs;              //分割后的状态转移符号
        private JmpTab[] jmpTabs;       //跳转函数表
        private string[] jmpEnds;       //终止符号串集合

        public TabClass()
        {
            length = 0;
        }


        /// <summary>
        /// 将字符串分割
        /// 例子：str=q0 q1 q2 q3 q4 q5
        /// 结果：str=q0|q1|q2|q3|q4|q5
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private string ChangeString(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                char ch = str[i];
                if (ch < 47 || ch > 122 || (ch > 57 && ch < 65) || (ch > 90 && ch < 97))
                {
                    str = str.Remove(i, 1);
                    str = str.Insert(i, " ");
                }
            }
            if (str.Length <= 0) return null;
            str = str.Insert(0, " ");
            for (int i = 1; i < str.Length; i++)
            {
                if (str[i] == ' ' && str[i - 1] == ' ')
                {
                    str = str.Remove(i, 1);
                    i--;
                }
            }
            str = str.Trim();
            str = str.Replace(' ', '|');
            return str;
        }


        /// <summary>
        /// 建立状态集合表
        /// 例子：str=q0|q1|q2|q3|q4|q5
        /// 结果：str[]={q0,q1,q2,q3,q4,q5} length=6
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private int DivStatues(string str)
        {
            if (str == null) return -1;
            statueTabs = str.Split('|');
            length = statueTabs.Length;
            return 0;
        }


        /// <summary>
        /// 获取状态对应的顺序
        /// 例子：  状态表 str[]={q0,q1,q2,q3,q4,q5} length=6
        ///         str=q2
        /// 结果：  return 2
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public int GetOrder(string str)
        {
            for (int i = 0; i < length; i++)
            {
                if (statueTabs[i] == str)
                {
                    return i;
                }
            }
            return -1;
        }


        /// <summary>
        /// 根据状态的顺序获取状态字符串
        /// 例子：状态表 str[]={q0,q1,q2,q3,q4,q5} length=6
        ///       order=2
        /// 结果：return q2
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        public string GetStatue(int order)
        {
            if (order < 0 || order > length) return null;
            return statueTabs[order];
        }


        /// <summary>
        /// 分割状态转移函数并建立字符串数组
        /// 例子：str = d|q0|a|q1a|X|R|d|q0|b|q1b|Y|R|;
        /// 结果：Jmpfuncs= {d,q0,a,q1a,X,R,d,q0,b,q1b,Y,R} 
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private int DivJmpFunc(string str)
        {
            if (str == null) return -1;
            Jmpfuncs = str.Split('|');
            return 0;
        }


        /// <summary>
        /// 构建跳转函数表
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private int BuildJmpTab()
        {
            jmpTabs = new JmpTab[length];
            for (int i = 0; i < length; i++)
            {
                jmpTabs[i] = new JmpTab();
            }

            for (int i = 0; i < Jmpfuncs.Length; i += 6)
            {
                int x = GetOrder(Jmpfuncs[i + 1]);
                if (x < 0 || x > length) return -1;
                JmpTab jmp = jmpTabs[x];
                while (jmp.next != null)
                {
                    jmp = jmp.next;
                }
                jmp.read = Jmpfuncs[i + 2][0];
                jmp.write = Jmpfuncs[i + 4][0];
                if (Jmpfuncs[i + 5][0] == 'l' || Jmpfuncs[i + 5][0] == 'L')
                {
                    jmp.direction = -1;
                }
                else if (Jmpfuncs[i + 5][0] == 'r' || Jmpfuncs[i + 5][0] == 'R')
                {
                    jmp.direction = 1;
                }
                else { jmp.direction = 0; }
                jmp.statue = GetOrder(Jmpfuncs[i + 3]);
                jmp.next = new JmpTab();
            }
            return 0;
        }


        /// <summary>
        /// 终止符号串集合
        /// 输入： q3|q4
        /// 结果： jmpEnds = {q3,q4}
        /// </summary>
        /// <param name="str">输入的字符串</param>
        /// <returns></returns>
        private int DivEndStatue(string str)
        {
            if (str == null) return -1;
            jmpEnds = str.Split('|');
            return 0;
        }


        /// <summary>
        /// 根据状态转移函数获取结果信息
        /// </summary>
        /// <param name="statue">当前状态</param>
        /// <param name="read">读取字符</param>
        /// <param name="write">写入字符</param>
        /// <param name="direction">转移方向</param>
        /// <param name="nextstatue">下一个状态</param>
        /// <returns></returns>
        public int GetJmpInfo(int statue, char read, ref char write, ref int direction, ref int nextstatue)
        {
            if (statue < 0 || statue > length) return -1;
            JmpTab jmp = jmpTabs[statue];
            while (jmp.next != null)
            {
                if (jmp.read == read)
                {
                    write = jmp.write;
                    direction = jmp.direction;
                    nextstatue = jmp.statue;
                    return 0;
                }
                jmp = jmp.next;
            }
            return -1;
        }


        /// <summary>
        /// 判断是否是终止状态
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        public int IsEndStatue(int order)
        {
            for (int i = 0; i < jmpEnds.Length; i++)
            {
                if (GetOrder(jmpEnds[i]) == order) return 1; 
            }
            return -1;
        }


        /// <summary>
        /// 该类的初始化操作
        /// 并且检测
        /// </summary>
        /// <param name="statues"></param>
        /// <param name="endstatue"></param>
        /// <param name="jmpfunc"></param>
        /// <returns></returns>
        public int Init(string statues, string endstatue, string jmpfunc)
        {
            int x;

            statues = ChangeString(statues);
            if (DivStatues(statues) == -1) return -1;

            endstatue = ChangeString(endstatue);
            if (DivEndStatue(endstatue) == -1) return -2;

            jmpfunc = ChangeString(jmpfunc);
            if (DivJmpFunc(jmpfunc) == -1) return -3;

            x = Detection();
            if (x > 0) return x;
            if (BuildJmpTab() == -1) return -4;

            return 0;
        }


        /// <summary>
        /// 检测是否符合建立状态检测表
        /// 前提必须已经建立好状态转移表
        /// </summary>
        /// <returns></returns>
        private int Detection()
        {
            if (statueTabs == null || jmpEnds == null || Jmpfuncs == null) return 1;
            int x = 0, y = 0;
            int i, j, k;
            for (i = 0; i < jmpEnds.Length; i++)
            {
                for (j = 0; j < statueTabs.Length; j++)
                {
                    if (jmpEnds[i] == statueTabs[j])
                    {
                        x++;
                        break;
                    }
                }
            }
            if (x != jmpEnds.Length) return 2;

            if (Jmpfuncs.Length % 6 != 0) return 3;
            x = 0;
            y = 0;
            for (i = 0; i < Jmpfuncs.Length; i+=6)
            {
                for (j = 0; j < statueTabs.Length; j++)
                {
                    if (Jmpfuncs[i + 1] == statueTabs[j])
                    {
                        x++;
                        break;
                    }
                }
                for (k = 0; k < statueTabs.Length; k++)
                {
                    if (Jmpfuncs[i + 3] == statueTabs[k])
                    {
                        y++;
                        break;
                    }
                }
            }
            if (x != y || Jmpfuncs.Length/6 != x) return 4;

            x = 0;
            for (i = 0; i < Jmpfuncs.Length; i += 6)
            {
                for (j = 0; j < jmpEnds.Length; j++)
                {
                    if (Jmpfuncs[i + 3] == jmpEnds[j])
                    {
                        x++;
                        goto First;
                    }
                }
            }
        First: if (x <= 0) return 5;

            for (i = 0; i < Jmpfuncs.Length; i += 6)
            {
                if (Jmpfuncs[i + 2].Length > 2 || Jmpfuncs[i + 4].Length > 2 || Jmpfuncs[i + 5].Length > 2) return 6;
            }

            return 0;
        }
        
    }
}
