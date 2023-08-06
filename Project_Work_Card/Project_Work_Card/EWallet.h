#pragma once

/// <summary>
/// Создать исключения если насёт повторяющихся Э почт и телефонных номеров
/// должен идти по списку пользователей и смотреть есть ли одинаковые номера или Эпочты и если есть кидать сообщение что "такое уже есть, напиши новое"
/// </summary>
class EWallet
{
public:
	EWallet() = default;

	//EWallet
	void registerUser() 
	{
		EWalletOwner.setName();
		EWalletOwner.setSurname();
		EWalletOwner.setBirthday();
		if (EWalletOwner.getDateBirth().getAge() < 18)
		{
			throw Exception("\nYou are not 18, Get out\n");
		}
		EWalletOwner.setEmail();
		EWalletOwner.setPhone();

		do {
			std::cout << "Enter password (first letter must be capital; you can use . or _ ;including digits; capacity min 8 symols max 15): ";
			std::cin >> password;
		} while (!isValidPassword(password));


		std::ofstream file("EWalletUserInfo.txt", std::ios::app);
		if (!file) {
			throw std::runtime_error("Failed to open file for writing.");
		}
		file << EWalletOwner.getName() << " " << EWalletOwner.getSurname() << " " << EWalletOwner.getDateBirth().getAge() << EWalletOwner.getEmail() << " " << password << " " << EWalletOwner.getPhone() << std::endl;
		file.close();

		std::cout << "\nRegistration successful!" << std::endl;
	}

	void loginUser()
	{
		std::string inputEmail{};
		std::string inputPassword{};

		std::cout << "\nEnter your email: ";
		std::cin >> inputEmail;

		std::cout << "\nEnter your password: ";
		std::cin >> inputPassword;

		std::ifstream file("EWalletUserInfo.txt");
		if (!file)
		{
			throw std::runtime_error("Failed to open file for reading.");
		}

		std::string userName, userSurname, userAge, userEmail, userPassword;
		std::string line;
		bool loggedIn = false;
		while (file >> userName >> userSurname >> userAge >> userEmail >> userPassword)
		{
			if (userEmail == inputEmail && userPassword == inputPassword)
			{
				loggedIn = true;
				break;
			}

		}
		file.close();
		
		if (loggedIn)
			std::cout << "\nLogin successful!" << std::endl;

		else
			std::cout << "\nLogin failed. Invalid email or password." << std::endl;

	}

	void EWalletOwnerInfo()
	{
		std::string inputEmail{};
		std::string inputPassword{};

		std::cout << "\nEnter your email: ";
		std::cin >> inputEmail;

		std::cout << "\nEnter your password: ";
		std::cin >> inputPassword;

		std::ifstream file("EWalletUserInfo.txt");
		if (!file)
		{
			throw std::runtime_error("Failed to open file for reading.");
		}

		std::string userName, userSurname, userAge, userEmail, userPassword, userPhone;
		bool loggedIn = false;
		while (file >> userName >> userSurname >> userAge >> userEmail >> userPassword >> userPhone)
		{
			if (userEmail == inputEmail && userPassword == inputPassword)
			{
				loggedIn = true;
				break;
			}

		}
		file.close();

		if (loggedIn)
		{
			std::cout << "Hi " << userName << " " << userSurname << "\n\n";
			std::cout << "Name: " << userName << "\n";
			std::cout << "Surname: " << userSurname << "\n";
			std::cout << "Email: " << userEmail << "\n";
			std::cout << "Age: " << userAge << "\n";
			std::cout << "Phone number: " << userPhone << "\n";
		}

		else
			std::cout << "Idi otsuda xuligan\n";
	
	}

	//Debit
	void addDebitCard()
	{
		cardOwnerDebit.registrUser();
	}

	void amountSendTo()
	{
		std::string IdSendCard, passwordSendCard, IdReceivedCard;
		double sendAmount{};

		std::cout << "Enter the Id of the card from which you send: ", std::cin >> IdSendCard;
		std::cout << "Enter the password of the card: ", std::cin >> passwordSendCard;
		cardOwnerDebit.login(IdSendCard, passwordSendCard);
		std::cout << "Enter the price you want to send: ", std::cin >> sendAmount;
		std::cout << "Enter the card Id to send to: ", std::cin >> IdReceivedCard;

		std::time_t currentTime = std::time(nullptr);
		std::tm* localTime = std::localtime(&currentTime);
		int day = localTime->tm_mday;
		int mounth = localTime->tm_mon + 1;

		categoryChoise(day, mounth, sendAmount);

		std::fstream file("usersDebitCard.txt", std::ios::in | std::ios::out);
		if (!file)
		{
			throw std::runtime_error("Failed to open file for reading and writing.");
		}

		std::string userName, userSurname, userID, userPassword, userAmount;
		bool foundUser = false;
		while (file >> userName >> userSurname >> userID >> userPassword >> userAmount)
		{
			if (userID == IdSendCard && userPassword == passwordSendCard)
			{
				double newAmount = std::stod(userAmount) + sendAmount;
				file.seekp(file.tellg());
				file << userName << " " << userSurname << " " << userID << " " << userPassword << " " << newAmount << std::endl;
				foundUser = true;
				break;
			}
		}

		if (!foundUser)
		{
			std::cout << "Invalid email or password Or this person does not exist in the database" << std::endl;
		}

		file.close();

	}

	void amountSpendDebit()
	{
		std::string IdSpendCard, passwordSpendCard;
		double spendAmount{};

		std::cout << "Enter the Id of the card from which you spend: ", std::cin >> IdSpendCard;
		std::cout << "Enter the password of the card: ", std::cin >> passwordSpendCard;
		cardOwnerDebit.login(IdSpendCard, passwordSpendCard);
		std::cout << "Enter the price you want to spend: ", std::cin >> spendAmount;

		cardOwnerDebit.amountDebitRefill(spendAmount);

		std::time_t currentTime = std::time(nullptr);
		std::tm* localTime = std::localtime(&currentTime);
		int day = localTime->tm_mday;
		int mounth = localTime->tm_mon + 1;

		categoryChoise(day, mounth, spendAmount);

		std::fstream file("usersDebitCard.txt", std::ios::in | std::ios::out);
		if (!file)
		{
			throw std::runtime_error("Failed to open file for reading and writing.");
		}

		std::string userName, userSurname, userID, userPassword, userAmount;
		bool foundUser = false;
		while (file >> userName >> userSurname >> userID >> userPassword >> userAmount)
		{
			if (userID == IdSpendCard && userPassword == passwordSpendCard)
			{
				double newAmount = std::stod(userAmount) - spendAmount;
				if (newAmount < 0)
				{
					throw Exception("\nYou don't have enough means! Go to work beggar\nNo money no funny\n");
				}
				file.seekp(file.tellg());
				file << userName << " " << userSurname << " " << userID << " " << userPassword << " " << newAmount << std::endl;
				foundUser = true;
				break;
			}
		}

		if (!foundUser)
		{
			std::cout << "Invalid email or password Or this person does not exist in the database" << std::endl;
		}

		file.close();
	}


	//Credit
	void addCreditCard()
	{
		cardOwnerCredit.registrUser();
	}

	void amountSpendCredit()
	{
		std::string IdSpendCard, passwordSpendCard;
		double spendAmount{};

		std::cout << "Enter the Id of the credit card from which you spend: ", std::cin >> IdSpendCard;
		std::cout << "Enter the password of the credit card: ", std::cin >> passwordSpendCard;
		cardOwnerCredit.login(IdSpendCard, passwordSpendCard);
		std::cout << "Enter the price you want to spend: ", std::cin >> spendAmount;

		std::time_t currentTime = std::time(nullptr);
		std::tm* localTime = std::localtime(&currentTime);
		int day = localTime->tm_mday;
		int mounth = localTime->tm_mon + 1;

		categoryChoise(day, mounth, spendAmount);

		std::fstream file("usersCreditCard.txt", std::ios::in | std::ios::out);
		if (!file)
		{
			throw std::runtime_error("Failed to open file for reading and writing.");
		}

		std::string userName, userSurname, userID, userPassword, userMustPayAmount;
		bool foundUser = false;
		while (file >> userName >> userSurname >> userID >> userPassword >> userMustPayAmount)
		{
			if (userID == IdSpendCard && userPassword == passwordSpendCard)
			{
				double newMustPayAmount = (std::stod(userMustPayAmount) + spendAmount) + (( std::stod(userMustPayAmount) + spendAmount ) * cardOwnerCredit.getPercent()) / 12;
				file.seekp(file.tellg());
				file << userName << " " << userSurname << " " << userID << " " << userPassword << " " << newMustPayAmount << std::endl;
				foundUser = true;
				break;
			}
		}

		if (!foundUser)
		{
			std::cout << "Invalid email or password Or this person does not exist in the database" << std::endl;
		}

		file.close();
	}

	void repayCredit(double amountSpend)
	{
		std::string inputIdCreditCard{};
		std::cout << "Enter ID credit card for repay Credir: ", std::cin >> inputIdCreditCard;

		std::fstream file("usersCreditCard.txt", std::ios::in | std::ios::out);
		if (!file)
		{
			throw std::runtime_error("Failed to open file for reading and writing.");
		}

		std::string userName, userSurname, userID, userPassword, userMustPayAmount;
		bool foundUser = false;
		while (file >> userName >> userSurname >> userID >> userPassword >> userMustPayAmount)
		{
			if (userID == inputIdCreditCard)
			{
				double newMustPayAmount = (std::stod(userMustPayAmount) - amountSpend) + ((std::stod(userMustPayAmount) - amountSpend) * cardOwnerCredit.getPercent()) / 12;
				file.seekp(file.tellg());
				file << userName << " " << userSurname << " " << userID << " " << userPassword << " " << newMustPayAmount << std::endl;
				foundUser = true;
				break;
			}
		}
	}
	
	//Categories
	void categoryProducts(int day, int mounth, double amount)
	{
		std::ofstream file("CategoryProducts.txt", std::ios::app);
		if (!file) {
			throw std::runtime_error("Failed to open file for writing.");
		}

		file << day << " " << mounth << " " << amount << std::endl;
		file.close();
	}

	void categoryMedichine(int day, int mounth, double amount)
	{
		std::ofstream file("CategoryMedichine.txt", std::ios::app);
		if (!file) {
			throw std::runtime_error("Failed to open file for writing.");
		}

		file << day << " " << mounth << " " << amount << std::endl;
		file.close();
	}

	void categoryTransport(int day, int mounth, double amount)
	{
		std::ofstream file("CategoryTransport.txt", std::ios::app);
		if (!file) {
			throw std::runtime_error("Failed to open file for writing.");
		}

		file << day << " " << mounth << " " << amount << std::endl;
		file.close();
	}
	
	void categoryEntertainment(int day, int mounth, double amount)
	{
		std::ofstream file("CategoryEntertainment.txt", std::ios::app);
		if (!file) {
			throw std::runtime_error("Failed to open file for writing.");
		}

		file << day << " " << mounth << " " << amount << std::endl;
		file.close();
	}

	void categoryCredit(int day, int mounth, double amount)
	{
		std::ofstream file("CategoryCredit.txt", std::ios::app);
		if (!file) {
			throw std::runtime_error("Failed to open file for writing.");
		}

		file << day << " " << mounth << " " << amount << std::endl;
		file.close();
	}

	void categoryOther(int day, int mounth, double amount)
	{
		std::ofstream file("CategoryOther.txt", std::ios::app);
		if (!file) {
			throw std::runtime_error("Failed to open file for writing.");
		}

		file << day << " " << mounth << " " << amount << std::endl;
		file.close();
	}

	void categoryChoise(int day, int mounth, double amountSpend)
	{
		unsigned short choise{};
		std::cout << "Enter number which category your spending belongs to: \n";
		std::cout << "1) Products: \n";
		std::cout << "2) Medichine: \n";
		std::cout << "3) Transport: \n";
		std::cout << "4) Entertainment: \n";
		std::cout << "5) Credit: \n";
		std::cout << "6) Other: \n";
		std::cin >> choise;

		switch (choise)
		{
		case 1:
		{
			system("cls");
			categoryProducts(day, mounth, amountSpend);
			break;
		}
		case 2:
		{
			system("cls");
			categoryMedichine(day, mounth, amountSpend);
			break;
		}
		case 3:
		{
			system("cls");
			categoryTransport(day, mounth, amountSpend);
			break;
		}
		case 4:
		{
			system("cls");
			categoryEntertainment(day, mounth, amountSpend);
			break;
		}

		case 5:
		{
			system("cls");
			repayCredit(amountSpend);
			categoryCredit(day, mounth, amountSpend);
			break;
		}
		case 6:
		{
			system("cls");
			categoryOther(day, mounth, amountSpend);
			break;
		}
		default:
			system("cls");
			std::cout << "\nThere are 6 digits. What do you not understand? Choose one of 5. Why should I write a check for this?\n";
			categoryChoise(day, mounth, amountSpend);
			break;
		}

	}

	//Top 3 Pays Catigories
	//P.s Эту часть кода я позаимствовал у чат гпт, я бы мог бы сделать по другому(подробнее внизу), но зато я теперь понял что вы имели ввиду под "Объеденить структуры данных" Это гениально
	// Закоментриванная часть кода, что я хотел сделать: Добавить в эти веторы кол-во потр денег, Отсортировать. потом используя словарь используя потраченные деньги как ключ вызывать нужный значение т.е нужную категорию
	//P.s2 я ещё ко что позаимствовал у чат гпт но не подписал а искать лень, но на этом всё))
	void top3Catigories()
	{
		std::time_t currentTime = std::time(nullptr);
		std::tm* localTime = std::localtime(&currentTime);
		int currentDay = localTime->tm_mday;
		int currentMounth = localTime->tm_mon + 1;

		//std::vector<double> sumCatigoriesWeek{};
		//std::vector<double> sumCatigoriesMounth{};
		std::map< double, std::string> paysCategoriesWeek{};
		std::map< double, std::string> paysCategoriesMounth{};
		std::string categories[] = { "CategoryProducts", "CategoryMedichine", "CategoryTransport", "CategoryEntertainment", "CategoryCredit", "CategoryOther"};

		for (const std::string& category : categories)
		{
			std::string fileName = category + ".txt";

			std::ifstream file(fileName);
			if (!file) 
			{
				std::cout << "Failed to open file or it is doesn't exsits: " << fileName << std::endl;
				continue;
			}

			double totalSumWeek{}, totalSumMounth{};
			std::string day, mount, strNumber;
			while (file >> day >> mount >> strNumber)
			{
				if (currentDay - 7 < std::stoi(day) && std::stoi(mount) == currentMounth)
				{
					totalSumWeek += std::stod(strNumber);
				}
				if (std::stoi(mount) == currentMounth)
				{
					totalSumMounth += std::stod(strNumber);
				}
			}
			paysCategoriesWeek[totalSumWeek] = fileName;
			paysCategoriesMounth[totalSumWeek] = fileName;

			file.close();
		}
		std::vector<std::pair<double, std::string>> sortedPaysWeek(paysCategoriesWeek.begin(), paysCategoriesWeek.end());
		std::vector<std::pair<double, std::string>> sortedPaysMounth(paysCategoriesMounth.begin(), paysCategoriesMounth.end());

		std::sort(sortedPaysWeek.begin(), sortedPaysWeek.end(), [](const auto& a, const auto& b)
		{
			return a.first > b.first;
		});

		std::sort(sortedPaysMounth.begin(), sortedPaysMounth.end(), [](const auto& a, const auto& b)
		{
			return a.first > b.first;
		});

		std::cout << "Top 3 pays for Week:" << std::endl;
		for (size_t i = 0; i < 3 && i < sortedPaysWeek.size(); ++i) {
			std::cout << sortedPaysWeek[i].second << ": " << sortedPaysWeek[i].first << std::endl;
		}

		std::cout << "\nTop 3 pays for Mounth:" << std::endl;
		for (size_t i = 0; i < 3 && i < sortedPaysMounth.size(); ++i) {
			std::cout << sortedPaysMounth[i].second << ": " << sortedPaysMounth[i].first << std::endl;
		}

	}


private:
	PersonDate EWalletOwner{};
	std::string password{};
	DebitCard cardOwnerDebit;
	CreditCard cardOwnerCredit;


	bool isValidPassword(std::string& password) const {
		std::regex passwordRegex("^([A-Z])(?=.*[._]?)([a-zA-Z0-9._]+){7,15}$");
		return regex_match(password, passwordRegex);
	}

	bool isValidID(std::string& ID)const
	{
		std::regex IDRegex("^([0-9]){16}$");
		return regex_match(ID, IDRegex);
	}

};
