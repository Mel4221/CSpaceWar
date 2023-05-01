//
// ${Melquiceded Balbi Villanueva}
//
// Author:
//       ${Melquiceded} <${melquiceded.balbi@gmail.com}>
//
// Copyright (c) ${2089} MIT
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
using System;
using QuickTools.QCore;
using QuickTools.QConsole;
using System.Threading;
namespace CSpaceWar
      {
      public class Space
            {
                        public int Max_X;
                        public int Max_Y;
                        public int Min_X;
                        public int Min_Y; 


 
                  internal void Show(SpaceShip spaceShip , EnemySpaceShip enemy)
                  {
                        //Get.Yellow($"{spaceShip.Location[0]} : {spaceShip.Location[1]}");
                        Console.SetCursorPosition(spaceShip.Location[0] , spaceShip.Location[1]);
                        Console.Write(spaceShip.Ship);
                       
                        Console.SetCursorPosition(enemy.Location[0], enemy.Location[1]);
                        Console.Write(enemy.Ship);
                       
                        Thread.Sleep(60);
                        Console.Clear(); 
                  //Get.Clear(true);
                        

                        // Console.SetCursorPosition(enemy.Location[0] , enemy.Location[1]);
                      
                      
                  }

            public Space()
                  {
                        this.Max_X = Console.BufferWidth;
                        this.Max_Y = Console.BufferHeight;
                        this.Min_X = 1;
                        this.Min_Y = 1;
                  }

         
            }
      }
