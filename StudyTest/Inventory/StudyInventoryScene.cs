﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SprtaaaaDungeon.StudyTest.Inventory
{
    public class StudyInventoryScene : Scene
    {
        //int maxPage; maxPage 는 곧 리스트의 길이이므로 필요없음

        public StudyInventoryScene(SceneController controller) : base(controller)
        {
            //게임매니저에서 가져와야함!
            //inventoryController = new InventoryController();


            //카테고리를 이차원 리스트로 바꿨어요~
            //maxPage = inventoryController.CategorizedItems.Count - 1;

            /*foreach (var item in inventoryController.CategorizedItems)
            {
                itemTypeList.Add(item.Key);
            }*/
        }


        public override void Start()
        {
            /*Console.Clear();
            itemTypeList.Clear();
            foreach (var item in inventoryController.CategorizedItems)
            {
                itemTypeList.Add(item.Key);
            }

            currentPage = itemTypeList.Count > 0 ? 0 : -1;
            maxPage = itemTypeList.Count - 1;

            // 진단용 디버깅 출력
            Console.WriteLine("===== [디버그 정보] =====");
            Console.WriteLine($"- inventoryController.Items.Count: {inventoryController.Items.Count}");
            Console.WriteLine($"- itemTypeList.Count: {itemTypeList.Count}");
            Console.WriteLine($"- currentPage: {currentPage}");
            Console.WriteLine($"- maxPage: {maxPage}");
            Console.WriteLine($"- CategorizedItems.Count: {inventoryController.CategorizedItems.Count}");
            Console.WriteLine("=========================\n");

            Console.WriteLine("인벤토리\n보유중인 아이템을 관리할 수 있습니다.\n");

            if (inventoryController.Items.Count == 0 || itemTypeList.Count == 0 || currentPage == -1)
            {
                Console.WriteLine("보유한 아이템이 없습니다.");
            }
            else
            {
                Console.WriteLine("[아이템 목록]");
                inventoryController.PrintItems(itemTypeList[currentPage]);
            }
            Console.WriteLine("1. 장착 관리");
            Console.WriteLine("2. 목록 전환");
            Console.WriteLine("0. 나가기\n");
            Console.Write("원하시는 행동을 입력해주세요.\n>> ");*/
        }

        public override void Update()
        {
            //입력방식이 ReadLine이 아닌 ReadKey 로 할꺼라 바꿀수밖에 없어요 ㅠㅠ
            /*string input = Console.ReadLine();

            switch (input)
            {
                case "0":
                    controller.ChangeScene(controller.PreviousScene);

                    break;
                case "2":
                    if (currentPage < maxPage)
                    {
                        currentPage++;
                    }
                    else
                    {
                        currentPage = 0;
                    }
                    Console.Clear();
                    Console.Write(itemTypeList.Count);
                    Console.Write(itemTypeList[currentPage]);
                    inventoryController.PrintItems(itemTypeList[currentPage]);
                    break;
                case "1":
                    while (true)
                    {
                        Console.Clear();
                        inventoryController.PrintItems(itemTypeList[currentPage]);
                        Console.WriteLine("\na. 목록 전환");
                        Console.WriteLine("\n0. 나가기");
                        Console.Write("\n장착/해제할 아이템 번호를 입력하세요\n>> ");
                        string select = Console.ReadLine();
                        int index;

                        select = select.ToLower();
                        if (select == "ㅁ") select = "a";
                        if (select == "a")
                        {
                            if (currentPage < maxPage)
                            {
                                currentPage++;
                            }
                            else
                            {
                                currentPage = 0;
                            }
                            Console.Clear();
                            inventoryController.PrintItems(itemTypeList[currentPage]);
                        }

                        else if (int.TryParse(select, out index))
                        {
                            if (select == "0")
                            {
                                Console.Clear();
                                Start();
                                break;
                            }

                            index -= 1;

                            if (!inventoryController.CategorizedItems.ContainsKey(itemTypeList[currentPage]))
                            {
                                Console.WriteLine("\n[오류] 현재 카테고리에 아이템이 없습니다.");
                                Console.WriteLine("Enter를 눌러 계속...");
                                Console.ReadLine();
                                continue;
                            }

                            List<InventoryItemData> currentList = inventoryController.CategorizedItems[itemTypeList[currentPage]];
                            if (index >= 0 && index < currentList.Count)
                            {
                                InventoryItemData item = currentList[index];

                                if (index < 0 || index >= currentList.Count)
                                {
                                    Console.WriteLine("\n[오류] 존재하지 않는 아이템 번호입니다.");
                                    Console.WriteLine("Enter를 눌러 계속...");
                                    Console.ReadLine();
                                    continue;
                                }

                                else if (item.ItemData.Type == GameEnum.ItemType.Consumable)
                                {
                                    Console.WriteLine("\n소비 아이템은 장착할 수 없습니다.");
                                    Console.WriteLine("\nEnter를 눌러 계속");
                                    Console.ReadLine();
                                }
                                else
                                {
                                    bool isEquipped = inventoryController.ToggleEquipState(item);
                                    Console.WriteLine(isEquipped
                                        ? $"\n'{item.ItemData.Name}' 장착 완료"
                                        : $"\n'{item.ItemData.Name}' 장착 해제됨");
                                    Console.WriteLine("\nEnter를 눌러 계속");
                                    Console.ReadLine();

                                    Console.Clear();
                                    inventoryController.PrintItems(itemTypeList[currentPage]);
                                }
                            }
                            else
                            {
                                Console.WriteLine("\n존재하지 않는 아이템 번호입니다");
                                Console.WriteLine("\nEnter를 눌러 계속");
                                Console.ReadLine();
                            }
                        }
                        else
                        {
                            Console.WriteLine("잘못된 입력입니다.");
                            Console.ReadLine();
                        }
                    }

                    Console.ReadLine();
                    Start();
                    break;

                default:
                    Console.WriteLine("잘못된 입력입니다.");
                    Console.ReadLine();
                    Start();
                    break;
            }*/
        }
        public override void End()
        {
        }

        /*  void DrawItemsFrame()
        {
            int left = layout.Center.X + 6;
            int right = layout.Center.Width - left;

            DrawString($"《x{left},y{layout.Center.Y}》┏━《l{layout.Center.Width - left - 11}》━《》━┓");

            for (int y = 1; y < layout.Center.Height - 3; y++)
            {
                DrawString($"《x{left},y{layout.Center.Y + y}》┃《x{right - 2}》┃");
            }

            DrawString($"《x{left},y{layout.Center.Y + layout.Center.Height - 3}》┗━《l{layout.Center.Width - left - 11}》━《》━┛");
        }*/
    }
}
