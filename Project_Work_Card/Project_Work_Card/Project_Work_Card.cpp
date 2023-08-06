#define _CRT_SECURE_NO_WARNINGS
#include <iostream>
#include <conio.h> 
#include <windows.h>
#include <ctime>
#include <vector>
#include <map>
#include <algorithm>
#include <utility>
#include "regex"
#include "fstream"
#include "Menues.h"
#include "PersonDate.h"
#include "Card.h"
#include "EWallet.h"



int main()
{
	EWallet eWallet;
	try
	{
		std::ifstream file("EWalletUserInfo.txt");
		if (!file.is_open()) {
			std::cout << "Failed to open the file." << std::endl;
			return 1;
		}

		if (file.peek() == std::ifstream::traits_type::eof()) {
			eWallet.registerUser();
		}
		else {
			eWallet.loginUser();
		}
		file.close();

		HANDLE console = GetStdHandle(STD_OUTPUT_HANDLE);
		while (true)
		{
			system("cls");
			system("color 70");
			for (int i = 0; i < menu_Length; i++)
			{
				if (i == selected_Index)
				{
					SetConsoleTextAttribute(console, 0x40);
					std::cout << "> " << menu[i] << std::endl;
					SetConsoleTextAttribute(console, 0x70);
				}

				else
					std::cout << menu[i] << std::endl;

			}
			int key = _getch();

			if (key == Key_Boards::up)
			{
				if (selected_Index > 0)
					selected_Index--;

				else if (selected_Index == 0)
					selected_Index = menu_Length - 1;
			}

			else if (key == Key_Boards::down)
			{
				if (selected_Index < menu_Length - 1)
					selected_Index++;

				else if (selected_Index == menu_Length - 1)
					selected_Index = 0;
			}

			else if (key == Key_Boards::enter)
			{
				system("cls");
				//ADD DEBIT CARD
				if (selected_Index == 0)
				{
					eWallet.addDebitCard();
				}

				//ADD CREDIT CARD
				else if (selected_Index == 1)
				{
					eWallet.addCreditCard();
				}

				//PAYMENT
				else if (selected_Index == 2)
				{
					selected_Index = 0;
					while (true)
					{
						system("cls");
						system("color 70");

						for (int i = 0; i < paymentMenu_Length; i++)
						{
							if (i == selected_Index)
							{
								SetConsoleTextAttribute(console, 0x40);
								std::cout << "> " << paymentMenu[i] << std::endl;
								SetConsoleTextAttribute(console, 0x70);
							}

							else
								std::cout << paymentMenu[i] << std::endl;

						}
						int key = _getch();

						if (key == Key_Boards::up)
						{
							if (selected_Index > 0)
								selected_Index--;

							else if (selected_Index == 0)
								selected_Index = paymentMenu_Length - 1;
						}

						else if (key == Key_Boards::down)
						{
							if (selected_Index < paymentMenu_Length - 1)
								selected_Index++;

							else if (selected_Index == paymentMenu_Length - 1)
								selected_Index = 0;
						}

						else if (key == Key_Boards::enter)
						{
							//PAY WITH DEBIT CARD
							if (selected_Index == 0)
							{
								selected_Index = 0;
								while (true)
								{
									system("cls");
									system("color 70");

									for (int i = 0; i < payWithDebitCardMenu_Length; i++)
									{
										if (i == selected_Index)
										{
											SetConsoleTextAttribute(console, 0x40);
											std::cout << "> " << payWithDebitCardMenu[i] << std::endl;
											SetConsoleTextAttribute(console, 0x70);
										}

										else
											std::cout << payWithDebitCardMenu[i] << std::endl;

									}
									int key = _getch();

									if (key == Key_Boards::up)
									{
										if (selected_Index > 0)
											selected_Index--;

										else if (selected_Index == 0)
											selected_Index = payWithDebitCardMenu_Length - 1;
									}

									else if (key == Key_Boards::down)
									{
										if (selected_Index < payWithDebitCardMenu_Length - 1)
											selected_Index++;

										else if (selected_Index == payWithDebitCardMenu_Length - 1)
											selected_Index = 0;
									}

									else if (key == Key_Boards::enter)
									{
										// SEND TO ANOTHER CARD
										if (selected_Index == 0)
										{
											system("cls");
											eWallet.amountSendTo();
										}

										//SPEND FOR SOMETHING IN CATEGORIES
										else if (selected_Index == 1)
										{
											system("cls");
											eWallet.amountSpendDebit();
										}
									}

								}
							}

							//PAY WITH CREDIT CARD
							else if (selected_Index == 1)
							{
								system("cls");
								eWallet.amountSpendCredit();
							}

						}


					}

				}

				//PAYMENT HISTORY
				else if (selected_Index == 3)
				{
					system("cls");
					eWallet.top3Catigories();
				}

				//EWALLET OWNER INFO
				else if (selected_Index == 4)
				{
					eWallet.EWalletOwnerInfo();
				}

				else if (selected_Index == 5)
				{
					std::cout << "   $$$    $$$" << std::endl;
					std::cout << " $$$$$$  $$$$$$" << std::endl;
					std::cout << "$$$$$$$$$$$$$$$" << std::endl;
					std::cout << " $$$$$$$$$$$$$" << std::endl;
					std::cout << "  $$$$$$$$$$" << std::endl;
					std::cout << "    $$$$$$" << std::endl;
					std::cout << "      $" << std::endl;
					std::cout << "\nDASVIDANIYA\n";
					return 0;
				}
			}

		}

	}
	catch (const std::exception& e)
	{
		std::cout << "Error: " << e.what();
	}
	return 0;

}