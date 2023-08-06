#pragma once

class Card
{
public:
	Card() = default;

	virtual void registrUser() = 0;

	virtual void login(std::string inputID, std::string inputPassword) = 0;

protected:
	PersonDate cardOwner{};
	std::string cardID{};
	std::string password{};

};




class DebitCard : public Card
{
public:
	DebitCard() = default;


	void registrUser() override
	{
		cardOwner.setName();
		cardOwner.setSurname();
		cardOwner.setBirthday();
		if (cardOwner.getDateBirth().getAge() < 18)
		{
			throw Exception("\nYou are not 18, Get out\n");
		}
		cardOwner.setEmail();
		cardOwner.setPhone();

		do
		{
			std::cout << "Enter card ID(must be only 16 numbers): ";
			std::cin >> cardID;
		} while (!isValidID(cardID));

		do
		{
			std::cout << "Enter password (only digits; capacity must be 4 digits): ";
			std::cin >> password;
		} while (!isValidPassword(password));


		std::ofstream file("usersDebitCard.txt", std::ios::app);
		if (!file)
			throw std::runtime_error("Failed to open file for writing.");

		file << this->cardOwner.getName() << " " << this->cardOwner.getSurname() << " " << this->cardID << " " 
		<< this->password << " " << this->amountDebit << this->cardOwner.getPhone() << std::endl;
		file.close();

		std::cout << "\nRegistration successful!" << std::endl;
	}

	void login(std::string inputID, std::string inputPassword) override
	{
		/*std::string inputID{};
		std::string inputPassword{};

		std::cout << "Enter your ID: ";
		std::cin >> inputID;

		std::cout << "Enter your password: ";
		std::cin >> inputPassword;*/

		std::ifstream file("usersDebitCard.txt");
		std::string userName, userSurname, userID, userPassword;
		bool loggedIn = false;
		while (file >> userName >> userSurname >> userID >> userPassword)
		{
			if (userID == inputID && userPassword == inputPassword)
			{
				std::cout << "Login successful!" << std::endl;
				break;
			}
			else
				std::cout << "Login failed. Invalid Id or password." << std::endl;
		}
		file.close();
	}
	
	void amountDebitRefill(double amount)
	{
		if (amount > 100000 || amount < 1)
			throw Exception("\nSorry but You can't send more than 1000000 azn or lees than 1\n");

		if (this->amountDebit + amount > 1000000)
			throw Exception("\nSorry but you can't keep in your card more than 1000000 azn\n");
	}

private:
	double amountDebit{};


	bool isValidPassword(std::string& password) const {
		std::regex passwordRegex("^([0-9]){4}$");
		return regex_match(password, passwordRegex);
	}

	bool isValidID(std::string& ID)const
	{
		std::regex IDRegex("^([0-9]){16}$");
		return regex_match(ID, IDRegex);
	}

};




class CreditCard : public Card
{
public:
	CreditCard() = default;

	void registrUser() override
	{
		cardOwner.setName();
		cardOwner.setSurname();
		cardOwner.setBirthday();
		if (cardOwner.getDateBirth().getAge() < 18)
		{
			throw Exception("\nYou are not 18, Get out\n");
		}
		cardOwner.setEmail();
		cardOwner.setPhone();

		do
		{
			std::cout << "Enter card ID(must be only 16 numbers): ";
			std::cin >> cardID;
		} while (!isValidID(cardID));

		do
		{
			std::cout << "Enter password (only digits; capacity must be 4 digits): ";
			std::cin >> password;
		} while (!isValidPassword(password));

		std::ofstream file("usersCreditCard.txt", std::ios::app);
		if (!file)
			throw std::runtime_error("Failed to open file for writing.");

		file << this->cardOwner.getName() << " " << this->cardOwner.getSurname() << " " << this->cardID << " "
		<< this->password << " " << this->mustPay << this->cardOwner.getPhone() << std::endl;
		file.close();

		std::cout << "\nRegistration successful!" << std::endl;
	}

	void login(std::string inputID, std::string inputPassword) override
	{
		/*std::string inputID{};
		std::string inputPassword{};

		std::cout << "Enter your ID: ";
		std::cin >> inputID;

		std::cout << "Enter your password: ";
		std::cin >> inputPassword;*/

		std::ifstream file("usersCreditCard.txt");
		std::string userName, userSurname, userID, userPassword;
		bool loggedIn = false;
		while (file >> userName >> userSurname >> userID >> userPassword)
		{
			if (userID == inputID && userPassword == inputPassword)
			{
				std::cout << "Login successful!" << std::endl;
				break;
			}
			else
				std::cout << "Login failed. Invalid Id or password." << std::endl;
		}
		file.close();
	}

	float getPercent()
	{
		return this->percent;
	}


private:
	double maxCreditSum = 100000;
	double mustPay{};
	float percent = 0.15f;

	bool isValidPassword(std::string& password)
	{
		std::regex passwordRegex("^([0-9]){4}$");
		return regex_match(password, passwordRegex);
	}

	bool isValidID(std::string & ID)const
	{
		std::regex IDRegex("^([0-9]){16}$");
		return regex_match(ID, IDRegex);
	}

};