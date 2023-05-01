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
using System.Threading; 
using QuickTools.QCore;
namespace CSpaceWar
      {
      public class GameRules
            {
            public int Lives = 3;
            public int Levels = 100;
            public Thread MainThread;
            public Thread SpaceThread;
            public Thread EnemysThread;
            public Thread SpaceShipThread;
            public Thread GameRulesThread;



            public enum Dificulty
                  {
                        Easy,
                        Normal,
                        Hard
                  }



                  public void Start()
                  {
                        SpaceShip spaceShip = new SpaceShip();
                        Space space = new Space();
                        EnemySpaceShip enemySpaceShip = new EnemySpaceShip();


                        this.SpaceShipThread = new Thread(()=> {
                              spaceShip.Play();
                        });
                        this.EnemysThread = new Thread(() => {
                              enemySpaceShip.Show();
                        });
                        this.SpaceThread = new Thread(() => {
                              while(true)
                                    {
                                    space.Show(spaceShip , enemySpaceShip);
                                          //Get.Green($"{spaceShip.Location[0]} : {enemySpaceShip.Location[1]}");
                                    }
                        });
                        this.GameRulesThread = new Thread(() => {

                        });


                  this.SpaceShipThread.Start();
                        this.EnemysThread.Start();
                        this.SpaceThread.Start();



                  }


                  public bool GameRuleChecker(Space space , SpaceShip spaceShip , EnemySpaceShip enemySpaceShip)
                  {
                  bool meet = false;
                              



                  return meet; 
                  }




                  public bool LimitChecker(Space space,SpaceShip spaceShip,EnemySpaceShip enemySpaceShip)
                  {
                       if(enemySpaceShip.Location[0] == space.Max_X || enemySpaceShip.Location[1] == space.Max_Y)
                        {
                              return true; 
                        }
                        if(enemySpaceShip.Location[0] == space.Min_X || enemySpaceShip.Location[1] == space.Min_Y)
                        {
                              return true;
                        }
                        if(spaceShip.Location[0] == space.Max_X || spaceShip.Location[1] == space.Max_Y)
                              {
                              return true;
                              }
                        if(spaceShip.Location[0] == space.Min_X || spaceShip.Location[1] == space.Min_Y)
                        {
                              return true;
                        }
                        else
                        {
                            return  false; 
                        }
                  }


            /// <summary>
            /// Check If on any of the X or Y they are matching the values which means that there was a crash
            /// </summary>
            /// <returns><c>true</c>, if check was collitioned, <c>false</c> otherwise.</returns>
            /// <param name="spaceShip">Space ship.</param>
            /// <param name="enemySpaceShip">Enemy space ship.</param>
            public bool CollitionCheck(SpaceShip spaceShip , EnemySpaceShip enemySpaceShip)
                  {
                  bool IsACrash = false; 
                        if(spaceShip.Location[0] == enemySpaceShip.Location[0] 
                        || spaceShip.Location[1] == enemySpaceShip.Location[1])
                        {
                              IsACrash = true; 
                        }
                  return IsACrash; 
                  }


            public GameRules()
                  {
                  }
            }
      }
