#pragma once

class Exception : public std::exception
{
public:
	Exception(const char* mesage)
	{
		this->mesage = mesage;
	}

	const char* what() const throw() override
	{
		return mesage;
	}

private:
	const char* mesage{};

};




struct DateBirth
{
public:
	unsigned int year{};
	unsigned int mounth{};
	unsigned int day{};

	DateBirth() = default;

	DateBirth(unsigned int day, unsigned int mounth, unsigned int year)
	{
		set_Year(year);
		set_Mounth(mounth);
		set_Day(day);
	}

	void set_Year(unsigned year)
	{
		if (year < 0)
			return;

		this->year = year;
	}

	void set_Mounth(unsigned mounth)
	{
		if (mounth < 0 || mounth > 12)
			return;

		this->mounth = mounth;
	}

	void set_Day(unsigned day)
	{
		if (day < 0 || day > 31)
			return;

		this->day = day;
	}


	unsigned int getAge() {
		time_t now = time(0);
		tm* ltm = localtime(&now);
		unsigned int age{};

		age = (ltm->tm_year + 1900) - this->get_Year();
		if (this->get_Mounth() > ltm->tm_mon + 1)
			age--;
		else if ((this->get_Mounth() == ltm->tm_mon + 1) && (this->get_Day() > ltm->tm_mday))
			age--;

		return age;
	}

	int get_Year()
	{
		return this->year;
	}

	int get_Mounth()
	{
		return this->mounth;
	}

	int get_Day()
	{
		return this->day;
	}

};



/// <summary>
/// Написать проверку на повторяющийся Э маил и телефонные номера
/// Тут такой прикол что все личные данные сохраняются в классе Card и EWalllet т.е тебе нужно посмотреть сначла это твой первый пользователь
/// Если да, просто пропустить провверку так как файла с пользователсями  ещё нет иначе пройтись по всем пользователям есть ли совпадения если есть кинуть throw
/// </summary>
class PersonDate
{
public:
	PersonDate() = default;

	void setName()
	{
		std::regex nameRegex("^([A-Z])([a-z]+)");
		do
		{
			std::cout << "\nEnter name(first letter must be capital): ";
			std::cin >> name;
		} while (!isValidNameSurname(name));
	}

	void setSurname()
	{
		std::regex surnameRegex("^([A-Z])([a-z]+)");
		do
		{
			std::cout << "\nEnter surname(first letter must be capital): ";
			std::cin >> surname;
		} while (!isValidNameSurname(surname));
	}

	void setBirthday()
	{
		unsigned int year{}, mounth{}, day{};
		std::cout << "\nEnter your year of birth: ";
		std::cin >> year;
		birthday.set_Year(year);

		std::cout << "\nEnter your mounth of birth: ";
		std::cin >> mounth;
		birthday.set_Mounth(mounth);

		std::cout << "\nEnter your day of birth: ";
		std::cin >> day;
		birthday.set_Day(day);
	}

	void setEmail()
	{
		std::regex emailRegex(R"(([a-zA-Z0-9](\.|_)?)+([a-zA-Z0-9])+@([a-zA-Z0-9])+((\.)[a-zA-Z]{2,})+)");
		do
		{
			std::cout << "\nEnter Email: ";
			std::cin >> email;
		} while (!isValidEmail(email));
	}

	void setPhone()
	{
		std::regex phoneRegex(R"(^\+994([0-9]){9}$)");
		do
		{
			std::cout << "\nEnter phone number(example: +994 012 345 67 89): ";
			std::cin >> phone;
		} while (!isValidPhone(phone));
	}


	std::string getName()
	{
		return this->name;
	}

	std::string getSurname()
	{
		return this->surname;
	}

	DateBirth getDateBirth()
	{
		return this->birthday;
	}

	std::string getEmail()
	{
		return this->email;
	}

	std::string getPhone()
	{
		return this->phone;
	}


private:
	std::string name{};
	std::string surname{};
	DateBirth birthday{};
	std::string email{};
	std::string phone{};


	bool isValidNameSurname(std::string nameSurname)const
	{
		std::regex nameRegex("^[A-Z][a-z]{2,10}$");
		return regex_match(nameSurname, nameRegex);
	}

	bool isValidEmail(std::string& email) const
	{
		std::regex emailRegex(R"(([a-zA-Z0-9](\.|_)?)+([a-zA-Z0-9])+@([a-zA-Z0-9])+((\.)[a-zA-Z]{2,})+)");
		return regex_match(email, emailRegex);
	}

	bool isValidPhone(std::string phone)
	{
		std::regex phoneRegex(R"(^\+994([0-9]){9}$)");
		return regex_match(phone, phoneRegex);
	}

};
