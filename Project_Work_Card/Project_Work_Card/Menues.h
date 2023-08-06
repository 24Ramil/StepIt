#pragma once

enum Key_Boards
{
    up = 72,
    down = 80,
    enter = 13
};
const int menu_Length = 6;
const int paymentMenu_Length = 2;
const int payWithDebitCardMenu_Length = 2;

int selected_Index = 0;

char menu[menu_Length][50]
{
    "Add Debit Card",
    "Add Credit Card",
    "Payment",
    "Payments history",
    "Info EWallet Owner",
    "Exit"
};


char paymentMenu[paymentMenu_Length][50]
{
    "Pay with Debit Card",
    "Pay with Credit Card"
};


char payWithDebitCardMenu[2][50]
{
    "Send to another card",
    "Spend"
};
