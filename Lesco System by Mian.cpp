#include <iostream>
#include <fstream>
#include <string>
#include <windows.h>
#include<conio.h>

int  changeclr = 1;//to change color 
HANDLE hStdOut = GetStdHandle(STD_OUTPUT_HANDLE);
using namespace std;

void rgb()
{
	SetConsoleTextAttribute(hStdOut, changeclr);
	changeclr += 1;
	if (changeclr > 15)
		changeclr = 1;
}

void instructions()
{
	ifstream inFile;
	inFile.open("Instruction.txt");
	if (!inFile)
	{
		cout << "error";
		exit(0);
	}
	char typer;
	while (!inFile.eof())
	{
		inFile.get(typer);

		if (!inFile.eof())
		{
			if (typer == 32)
				rgb();
			if (typer != 32) 
				Beep(303, 100);

				cout << typer;
			
		}

	
	}
	cout << endl;
	inFile.close();
}

char type = '\0';
char temp = '\0';
int check = 0;

class Customer
{
protected:

	static int customerID, month, meters;

	char CNIC[14], Phone[12];

	string customerName, customerAddress, connectionDate, Username;
	char Password[30];
	
	 int day, year;

	 string customerType;
	 string MeterType;

	int Regular_units, Peak_units;

	static bool Check;
public:

	Customer()
	{
		for (int i = 0; i < 13; i++)
			CNIC[i] = 0;

		for (int i = 0; i < 11; i++)
			Phone[i] = 0;

		customerName, customerAddress, connectionDate, Username = '\0';

	    Password[0] = '\0';

		day, year = 0;

		Regular_units, Peak_units = 0;

	}

	int CheckMeter_per_CNIC(string CNIC)
	{
		fstream fin;

		fin.open("CustomerInfo.txt", ios::in);

		char Data[500];
		int count = 0;

		while (fin.eof() == 0)
		{
			fin.getline(Data, 500);

			Data[18] = { '\0' };

			string arr = "";

			int idx = 0;
			for (int i = 5; i < 18; i++)
			{
				arr = arr + Data[i];
				idx++;
			}

			if (arr == CNIC)
				count++;


			if (fin.eof())
				break;
		}
		return count;
	}

	void setCustomer()
	{    
		customerID++;

		ofstream infoFile;

		infoFile.open("CustomerInfo.txt", ios::out | ios::app);

		setCNIC();
		if (Check && meters < 3)
		{
			infoFile << customerID << ","; // customer ID

			setName_Address();

			setPhone();

			infoFile << CNIC << "," << customerName << "," << customerAddress << "," << Phone << ",";
		}
		system("cls");

		infoFile.close();
	}

	void setCNIC()
	{

		cout << " \n Please Enter CNIC (without - ): ";
		cin >> CNIC;

		for (int i = 0; i < 13; i++)
		{
			if ((CNIC[i]) < 48 || (CNIC[i] > 57) || strlen(CNIC) != 13)
			{
				cout << "\n\n\t\t Wrong Input ! ";
				Sleep(350);
				system("cls");
				setCNIC();
			}
						
		}
		fstream fin;

		char check[14];
		string line;

		fin.open("NadraDB.txt", ios::in);

		do
		{
			fin.getline(check, 14, ',');

			if (strcmp(CNIC, check) == 0)
			{
				Check = 1;
				break;
			}
			else
				Check = 0;
		} while (getline(fin, line));

		fin.close();

		meters = CheckMeter_per_CNIC(CNIC);

		if (!Check)
		{
			cout << "\n\n\n\t CNIC DOES NOT EXIST IN NADRA DATABASE \n\n";
			Sleep(750);
			system("cls");
		}
		else if (meters == 3)
		{
			cout << "\n\n\n\t CAN NOT REGISTER A NEW METER ON THIS CNIC \n\n";
			Sleep(750);
			system("cls");
		}

		Sleep(250);
		system("cls");

	}

	void setName_Address()
	{  
		cin.ignore();
		cin.clear();

		cout << " \n Please Enter your Full Name: ";
		getline(cin, customerName);

		Sleep(400);
		system("cls");

		cout << " \n Please Enter your Complete Address: ";
		getline(cin, customerAddress);

		Sleep(400);
		system("cls");
	}

	void setPhone()
	{
		cout << " \n Please Enter Phone Number: ";
		cin >> Phone;

		for (int i = 0; i < 11; i++)
		{
			if ((Phone[i]) < 48 || (Phone[i] > 57) || strlen(Phone) != 11)
			{
				cout << "\n\t Wrong Input ! ";
				Sleep(300);
				system("cls");
				setPhone();
			}
		
		}

		Sleep(350);
		system("cls");
	}

	void setType()
	{

		bool flag = 1;

		while (flag)
		{
			cout << " \n\n Choose Customer Type: \t Domestic [ 1 ] \t Commercial [ 2 ]  ";

			type = _getch();
			type -= 48;

			switch (type)
			{
			case 1:
				customerType = "Domestic";
				flag = 0;
				break;
			case 2:
				customerType = "Commercial";
				flag = 0;
				break;
			default:
				cout << "\n\n Invalid Option ";
				Sleep(250);
				system("cls");
				break;
			}
		}

		Sleep(250);
		system("cls");

		flag = 1;

		while (flag)
		{
			cout << " \n\n Choose Meter Type: \t Single-Phase [ 1 ] \t Three-Phase [ 2 ]  ";

			type = _getch();
			type -= 48;

			switch (type)
			{
			case 1:
				MeterType = "Single-Phase";
				flag = 0;
				break;
			case 2:
				MeterType = "Three-Phase";
				flag = 0;
				break;
			default:
				cout << "\n\n Invalid Option ";
				Sleep(250);
				system("cls");
				break;
			}
		}

		Sleep(250);
		system("cls");

	} 

	void DefaultMeter()
	{
		if (type == 1)
		{		
			Regular_units = 0;
		}
		else if (type == 2)
		{
			Regular_units = 0;
			Peak_units = 0;
		}

		Sleep(150);
		system("cls");
	
	}

	void setCdate()
	{
		cout << " \n\n Connection Date (dd / mm / yyyy) : ";

		cout << " \n\n Day: ";
		do {
			cin >> day;
		} while (day < 1 || day > 30);

		cout << " \n Month: ";
		do {
			cin >> month;
		} while (month < 1 || month > 12);

		cout << " \n Enter Year: ";
		do {
			cin >> year;
		} while (year < 2021 || year > 2022);


		connectionDate = to_string(day) + "/" + to_string(month) + "/" + to_string(year);

		system("cls");
	}

	void printType()
	{
		fstream infile;
		infile.open("CustomerInfo.txt", ios::out | ios::app);

		infile << customerType << "," << MeterType << "," << connectionDate << "," << Regular_units << "," << Peak_units <<"         " << "\n";

		infile.close();
	}

	
};

class Tax_Tarrif
{
protected:

	int Dsp_price, Csp_price; // single phase
	int D3R_price, D3P_price; // Three Phase Domestic Reg & Peak
	int C3R_price, C3P_price; // Three Phase Commercial Reg & Peak

	int Sales_Tax_D, Sales_Tax_C, Fixed_Charges_D, Fixed_Charges_C;
public:

	Tax_Tarrif()
	{
		Dsp_price = 5;
		Csp_price = 15;

		D3R_price = 8;
		D3P_price = 12;

		C3R_price = 18;
		C3P_price = 25;

		Sales_Tax_D = 17;
		Sales_Tax_C = 25;
		Fixed_Charges_D = 150;
		Fixed_Charges_C = 250;
		
	}

	void setSinglePhase_R()
	{
		cout << " \n Single Phase Domestic Meter Unit Price = ";
		cin >> Dsp_price;
		
	}

	void setSinglePhase_C()
	{
		cout << " \n Single Phase Commercial Meter Unit Price = ";
		cin >> Csp_price;

	}

	void setThreePhase_D()
	{
		cout << " \n Three Phase Domestic Meter Off-Peak Unit Price = ";
		cin >> D3R_price;

		cout << " \n Three Phase Domestic Meter Peak Unit Price = ";
		cin >> D3P_price;

	}

	void setThreePhase_C()
	{
		cout << " \n Three Phase Commercial Meter Off-Peak Unit Price = ";
		cin >> C3R_price;

		cout << " \n Three Phase Commercial Meter Peak Unit Price = ";
		cin >> C3P_price;
		
    }
	
	void setSalesTax(int type)
	{
		if (type == 1)
		{
			cout << " \n Domestic Meter Sales Tax = ";
			cin >> Sales_Tax_D;
		}
		else if (type == 2)
		{
			cout << " \n Commercial Meter Sales Tax = ";
			cin >> Sales_Tax_C;
		}
		else
			cout << " Error ! \n";
	}

	void setFcharges(int type)
	{
		if (type == 1)
		{
			cout << " \n Domestic Meter Fixed Charges = ";
			cin >> Fixed_Charges_D;
		}
		else if (type == 2)
		{

			cout << " \n Commercial Meter Fixed Charges = ";
			cin >> Fixed_Charges_C;
		}
		else
			cout << " Error ! \n";
	}

	int getTarrif(int type)
	{
		switch (type)
		{
		case 1:
			return Dsp_price;
			break;

		case 2:
			return Csp_price;
			break;

		case 3:
			return D3R_price;
			break;

		case 4:
			return D3P_price;
			break;

		case 5:
			return C3R_price;
			break;

		case 6:
			return C3P_price;
			break;

		default:
			cout << " \n Wrong Input ! \n";
			break;
		}
	}

	int getDomesticTax()
	{
		return Sales_Tax_D;
	}

	int getCommercialTax()
	{
		return Sales_Tax_C;
	}

	int getDomesticFixed()
	{
		return Fixed_Charges_D;
	}

	int getCommercialFixed()
	{
		return Fixed_Charges_C;
	}
};

class Employee : public Customer, Tax_Tarrif
{
protected:

	static int Iday, Imonth, Iyear;

	char Username[30], Passcode[30];

	bool SignINstatus;

	int ECost, Charges, RCost, PCost, BCost;
	double Tax;

	int idNum;
	static int Row;

	string IssuanceDate;
	string Convert_To_String(char* a, int size)
	{
		int i;
		string s;
		for (i = 0; i < size; i++)
			s = s + a[i];

		return s;
	}

public:

	Employee()
	{
		Username[0] = '\0';
		Passcode[0] = '\0';
		SignINstatus = 0;
		ECost = 0;
		PCost = 0;
		RCost = 0;
		BCost = 0;
		Tax = 0.00;
		Charges = 0;
		IssuanceDate = '\0';
		idNum = 0;
		Row = 0;
	}

	bool CheckFile(char user[100], char pass[100])
	{
		char n[1000];

		char p[1000];

		ifstream fin("Employee.txt");

		while (fin.eof() == 0)
		{
			fin.getline(n, 999, ',');
			fin.getline(p, 999, '\n');

			if (strcmp(n, user) == 0 && strcmp(p, pass) == 0)
				return 1;
		}
		return 0;
	}

	void SignIn()
	{
		cout << "\n Enter UserName: ";
		cin >> Username;
		cout << " \n Enter Password: ";

		char var;
		int idx = 0;

		for (int i = 0; 1 ; i++) 
		{
			var = _getch();
			if (var == 13)
				break;
			if (var >= 32 && var <= 126)
			{
				Passcode[idx] = var;
				cout << " * ";
				idx++;
			}
		}
		Passcode[idx] = '\0';

		if (CheckFile(Username, Passcode))
		{
			SignINstatus = 1;

			cout << "\n\n Successfully Logged In \n";

			Sleep(600);
			system("cls");
		}
		else
		{
			cout << "\n\n  XXX UserName (or) Password is Incorrect XXX " << endl;
			Sleep(800);
			system("cls");
			SignIn();
		}
	}

	void ChangePassword() {

		cout << " \n\n Enter Username : ";
		char user[200];
		cin >> user;

		cout << "\n\n Enter Old Password: ";
		char pass[200];
		
		char var;
		int idx = 0;

		for (int i = 0; 1; i++)
		{
			var = _getch();
			if (var == 13)
				break;
			if (var >= 32 && var <= 126)
			{
				pass[idx] = var;
				cout << " * ";
				idx++;
			}
		}
		pass[idx] = '\0';

		if (CheckFile(user, pass))
		{ 
			char var;
			int idx = 0;

			cout << "\n\n Enter New Password : ";
			char pass2[200];
			
			for (int i = 0; 1; i++)
			{
				var = _getch();
				if (var == 13)
					break;
				if (var >= 32 && var <= 126)
				{
					pass2[idx] = var;
					cout << " * ";
					idx++;
				}
			}
			pass2[idx] = '\0';

			string* s = Store("Employee.txt");
			char oldset[200];
			char newset[200];

			strcpy_s(oldset, user);
			strcpy_s(newset, user);

			int i = strlen(oldset);
			int j = strlen(newset);

			oldset[i] = ',';
			newset[j] = ',';

			oldset[i + 1] = '\0';
			newset[j + 1] = '\0';

			strcat_s(oldset, pass);
			strcat_s(newset, pass2);
			
			string pre = Convert_To_String(oldset, strlen(oldset));

			string updated = Convert_To_String(newset, strlen(newset));

			for (int i = 0; i < count("Employee.txt") + 1; i++) {
				if (pre == s[i])
				{
					cout << " \n\n Password Changed Successfully ";
					s[i] = updated;

					Sleep(500);
					system("cls");
				}
			}
			WriteToFile(s,"Employee.txt");
		}
		else
			cout << " \n\n Wrong Username (or) Password ! \n";
	}

	void setMeterReading()
	{   		
		fstream infile;

		string line;
		char temp[500];
		char C[50], M[50];
		int size = 0;

		infile.open("CustomerInfo.txt", ios::in);

		for (int i = 0; i < Row - 1; i++)
			getline(infile, line);

		int i = 0;
		while (i < 5)
		{
			infile.getline(temp, 200, ',');
			i++;
		}

		infile.getline(C, 20, ',');
		size = strlen(C);
		Customer::customerType = Convert_To_String(C,size);

		infile.getline(M, 20, ',');
		size = strlen(M);
		Customer::MeterType = Convert_To_String(M, size);

		infile.close();

		if (Customer::MeterType == "Single-Phase")
		{
			cout << " \n Regular Units Consumed = ";
			cin >> Customer::Regular_units;
			Customer::Peak_units = 0;
		}
		else if (Customer::MeterType == "Three-Phase")
		{
			cout << " \n Regular Units Consumed = ";
			cin >> Customer::Regular_units;
			cout << " \n Peak Units Consumed = ";
			cin >> Customer::Peak_units;
		}

		Sleep(350);
		system("cls");
	}

	string Issuance()
	{
		cout << " \n\n Issuance Date (dd / mm / yyyy) : "; // 1/1/2022

		cout << " \n\n Day: ";
		do {
			cin >> Iday;

		} while (Iday < 1 || Iday > 5);

		cout << " \n Month: ";
		do {
			cin >> Imonth;
		} while (Imonth < 5 || Imonth > 12);

		cout << " \n Enter Year: ";
		do {
			cin >> Iyear;
		} while (Iyear != 2022);


		IssuanceDate = to_string(Iday) + "/" + to_string(Imonth) + "/" + to_string(Iyear);

		return IssuanceDate;

		Sleep(200);
		system("cls");
	}

	string getMonth()
	{
		switch (Imonth - 1)
		{
		case 1:
			return "January";
			break;
		case 2:
			return "February";
			break;
		case 3:
			return "March";
			break;
		case 4:
			return "April";
			break;
		case 5:
			return "May";
			break;
		case 6:
			return "June";
			break;
		case 7:
			return "July";
			break;
		case 8:
			return "August";
			break;
		case 9:
			return "September";
			break;
		case 10:
			return "October";
			break;
		case 11:
			return "November";
			break;
		case 12:
			return "December";
			break;
		default:
			return " ";
			break;
		}
	}

	void ID_check(string file)
	{
		char ID[5];
		int temp;

		
			cout << " \n\n Enter Customer ID: ";
			cin >> ID;

			for (int i = 0; i < 4; i++)
			{
				if ((ID[i]) < 48 || (ID[i] > 57) || strlen(ID) != 4)
				{
					cout << "\n\n\t\t Wrong Input ! ";
					Sleep(350);
					system("cls");
					ID_check(file);
				}
				

			}
		

		string id = Convert_To_String(ID, 4);

		temp = stoi(id);
		
		int check = checkID(file,temp);

		if (check)
		{
			idNum = temp;
			system("cls");

		}
		else
		{
			cout << " \n ID Does Not Exist in LESCO Record \n";

			Sleep(750);
			system("cls");

			ID_check(file);
		}

	}

	int GenerateBill()
	{   
		setMeterReading();

		Issuance();

		string line;
		char temp[50];
		int size = 0;
		int num1[3] = { 0,0,0 }, num2[4]= { 0,0,0,0 };

		if (Customer::customerType == "Domestic" && Customer::MeterType == "Single-Phase")
		{   
			fstream fin;

			fin.open("TaxTarrifInfo.txt", ios::in);
			
			fin.getline(temp, 10, ',');

			temp[0] = '\0';
			for (int i = 0 , j = 0; i < 4; i++)
			{
				temp[0] = '\0';
				line = "";

				fin.getline(temp, 10, ',');
				size = strlen(temp);
				line = Convert_To_String(temp, size);

				if (line != "")
				{
					num1[j] = stoi(line);
					j++;
				}
			}
			fin.close();

			Tax_Tarrif::Dsp_price = num1[0];
			Tax_Tarrif::Sales_Tax_D = num1[1];
			Tax_Tarrif::Fixed_Charges_D = num1[2];

			ECost = (Tax_Tarrif::getTarrif(1) * Customer::Regular_units);

			Tax = (Tax_Tarrif::getDomesticTax() * 0.01) * ECost;

			BCost = ECost + Tax;

			Charges = Tax_Tarrif::getDomesticFixed();

			BCost = BCost + Charges;

		}
		else if (Customer::customerType == "Commercial" && Customer::MeterType == "Single-Phase")
		{
			fstream fin;

			fin.open("TaxTarrifInfo.txt", ios::in);

			getline(fin, line);

			fin.getline(temp, 10, ',');

			temp[0] = '\0';

			for (int i = 0, j = 0; i < 4; i++)
			{
				temp[0] = '\0';
				line = "";

				fin.getline(temp, 10, ',');
				size = strlen(temp);
				line = Convert_To_String(temp, size);

				if (line != "")
				{
					num1[j] = stoi(line);
					j++;
				}
			}
			fin.close();

			Tax_Tarrif::Csp_price = num1[0];
			Tax_Tarrif::Sales_Tax_D = num1[1];
			Tax_Tarrif::Fixed_Charges_D = num1[2];

			ECost = (Tax_Tarrif::getTarrif(2) * Customer::Regular_units);

			Tax = (Tax_Tarrif::getDomesticTax() * 0.01) * ECost;

			BCost = ECost + Tax;

			Charges = Tax_Tarrif::getCommercialFixed();
			BCost = BCost + Charges;

		}
		else if (Customer::customerType == "Domestic" && Customer::MeterType == "Three-Phase")
		{
			fstream fin;

			fin.open("TaxTarrifInfo.txt", ios::in);

			getline(fin, line);
			getline(fin, line);

			fin.getline(temp, 10, ',');

			temp[0] = '\0';

			for (int i = 0; i < 4; i++)
			{
				temp[0] = '\0';
				line = "";

				fin.getline(temp, 10, ',');
				size = strlen(temp);
				line = Convert_To_String(temp, size);

				num2[i] = stoi(line);
			}
			fin.close();

			Tax_Tarrif::D3R_price = num2[0];
			Tax_Tarrif::D3P_price = num2[1];
			Tax_Tarrif::Sales_Tax_C = num2[2];
			Tax_Tarrif::Fixed_Charges_C = num2[3];

			RCost = (Tax_Tarrif::getTarrif(3) * Customer::Regular_units);

			PCost = (Tax_Tarrif::getTarrif(4) * Customer::Peak_units);

			ECost = RCost + PCost;

			Tax = (Tax_Tarrif::getDomesticTax() * 0.01) * ECost;

			BCost = ECost + Tax;

			Charges = Tax_Tarrif::getDomesticFixed();
			BCost = BCost + Charges;
		}
		else if (Customer::customerType == "Commercial" && Customer::MeterType == "Three-Phase")
		{
			fstream fin;

			fin.open("TaxTarrifInfo.txt", ios::in);

			getline(fin, line);
			getline(fin, line);
			getline(fin, line);

			fin.getline(temp, 10, ',');

			temp[0] = '\0';

			for (int i = 0; i < 4; i++)
			{
				temp[0] = '\0';
				line = "";

				fin.getline(temp, 10, ',');
				size = strlen(temp);
				line = Convert_To_String(temp, size);

				num2[i] = stoi(line);
			}
			fin.close();

			Tax_Tarrif::C3R_price = num2[0];
			Tax_Tarrif::C3P_price = num2[1];
			Tax_Tarrif::Sales_Tax_C = num2[2];
			Tax_Tarrif::Fixed_Charges_C = num2[3];

			RCost = (Tax_Tarrif::getTarrif(5) * Customer::Regular_units);

			PCost = (Tax_Tarrif::getTarrif(6) * Customer::Peak_units);

			ECost = RCost + PCost;

			Tax = (Tax_Tarrif::getCommercialTax() * 0.01) * ECost;

			BCost = ECost + Tax;

			Charges = Tax_Tarrif::getCommercialFixed();
			BCost = BCost + Charges;
		}
		else
			return 0;

		return BCost;

	}

	int ChangeStatus()
	{ 
		system("cls");

		char flag;
		int check;

		cout << "\n BILL PAID ( 1 )   [ OR ]  BILL UNPAID (0)  ";
		flag = _getch();

		check = flag - 48;

		if (check != 0 && check != 1)
		{
			system("cls");
			ChangeStatus();
		}
		return static_cast<int>(flag) - 48;
	}

	bool checkID(string s , int num)
	{
		ifstream billfile;

		char temp[500];
		char extract[5];

		string loop;

		billfile.open(s, ios::in);

		for(int i = 0; getline(billfile, loop) ; i++)
		{
			strcpy_s(temp, loop.c_str());

			for (int k = 0; k < 4; k++)
				extract[k] = temp[k];

			extract[4] = '\0';

			string ID = Convert_To_String(extract, 4);

			if (ID == to_string(num))
			{
				Row = i + 1;
				return 1;
			}
		}

		billfile.close();

		return 0;
	}
	
	void RegisterNewMeter()
	{   
		getId();
		Customer::setCustomer();
		if (Check && meters < 3)
		{
			Customer::setType();
			Customer::setCdate();
			Customer::DefaultMeter();
			Customer::printType();

			cout << " \n\n Successfully, New Meter Registered \n\n";
			Sleep(500);
		}
	}

	void ChangeTaxInfo() 
	{  
		char N;

		cout << "\n\n  Domestic Single Phase Tax & Tarrif   [ 1 ] \n";
		cout << "\n\n  Commercial Single Phase Tax & Tarrif [ 2 ] \n";
		cout << "\n\n  Domestc Three Phase Tax & Tarrif     [ 3 ] \n";
		cout << "\n\n  Commercial Three Phase Tax & Tarrif  [ 4 ] \n";
		cout << "\n\n  Exit                                 [ 0 ] \t";

		do {
			N = _getch();

		} while (N < 48 || N > 53);

		system("cls");

		N = static_cast<int>(N) - 48;

		fstream f;

		f.open("TaxTarrifInfo.txt"); //add tax tarrif here

		char A[30];
		for (int i = 0; i < N; i++) 
		{
			f.getline(A, 30);
		}
		string s = "\0";

		if (N == 1) 
		{
			s = "1Phase,";

			string First;
			
			Tax_Tarrif::setSinglePhase_R();
			First = to_string(Tax_Tarrif::getTarrif(1));

			s = s + First + ",,";

			Tax_Tarrif::setSalesTax(1);
			First = to_string(Tax_Tarrif::getDomesticTax());

			s = s + First + ",";
		
			Tax_Tarrif::setFcharges(1);
			First = to_string(Tax_Tarrif::getDomesticFixed());

			s = s + First;

			string* file = Store("TaxTarrifInfo.txt");

			file[N - 1] = "";
			file[N - 1] = s;
			WriteToFile(file, "TaxTarrifInfo.txt");
		}
		else if (N == 2) 
		{
			s = "1Phase,";

			string First;

			Tax_Tarrif::setSinglePhase_C();
			First = to_string(Tax_Tarrif::getTarrif(2));

			s = s + First + ",,";

			Tax_Tarrif::setSalesTax(1);
			First = to_string(Tax_Tarrif::getDomesticTax());

			s = s + First + ",";

			Tax_Tarrif::setFcharges(1);
			First = to_string(Tax_Tarrif::getDomesticFixed());
			s = s + First;

			string* file = Store("TaxTarrifInfo.txt");

			file[N - 1] = "";
			file[N - 1] = s;
			WriteToFile(file, "TaxTarrifInfo.txt");
		}
		else if (N == 3)
		{
			s = "3Phase,";

			string First;

			Tax_Tarrif::setThreePhase_D();
			First = to_string(Tax_Tarrif::getTarrif(3));

			s = s + First + ",";

			First = to_string(Tax_Tarrif::getTarrif(4));
			s = s + First + ",";

			Tax_Tarrif::setSalesTax(1);
			First = to_string(Tax_Tarrif::getDomesticTax());

			s = s + First + ",";

			Tax_Tarrif::setFcharges(1);
			First = to_string(Tax_Tarrif::getDomesticFixed());
			s = s + First;

			string* file = Store("TaxTarrifInfo.txt");

			file[N - 1] = "";
			file[N - 1] = s;
			WriteToFile(file, "TaxTarrifInfo.txt");
		}
		else if (N == 4)
		{
			s = "3Phase,";

			string First;

			Tax_Tarrif::setThreePhase_C();
			First = to_string(Tax_Tarrif::getTarrif(5));

			s = s + First + ",";

			First = to_string(Tax_Tarrif::getTarrif(6));
			s = s + First + ",";

			Tax_Tarrif::setSalesTax(2);
			First = to_string(Tax_Tarrif::getCommercialTax());

			s = s + First + ",";

			Tax_Tarrif::setFcharges(2);
			First = to_string(Tax_Tarrif::getCommercialFixed());
			s = s + First;

			string* file = Store("TaxTarrifInfo.txt");

			file[N - 1] = "";
			file[N - 1] = s;
			WriteToFile(file,"TaxTarrifInfo.txt");
		}
		else if(N==5)
		exit(0);
	}
	
	void getId()
	{   
		ifstream fin;

		fin.open("CustomerInfo.txt");

		if (fin.is_open()) 
		{
			fin.seekg(-3, ios_base::end);                // go to one spot before the EOF

			bool loop = true;

			while (loop) 
			{
				char ch;
				fin.get(ch);                            // Get current byte's data

				if ((int)fin.tellg() <= 1) {             // If the data was at or before the 0th byte
					fin.seekg(0);                       // The first line is the last line
					loop = false;                // So stop there
				}
				else if (ch == '\n') {                   // If the data was a newline
					loop = false;                // Stop at the current position.
				}
				else {                                  // If the data was neither a newline nor at the 0 byte
					fin.seekg(-2, ios_base::cur);        // Move to the front of that data, then to the front of the data before it
				}
			}

			char temp[10];

			fin.getline(temp , 10 ,',');      // Read the current line until del

			string S = Convert_To_String(temp, 4);

			customerID = stoi(S);
		
			fin.close();
		}
	}
;

	string* Store(string filename) 
	{
		fstream newfile;
		string* tp = new string[count(filename) + 1];
		int i = 0;
		newfile.open(filename, ios::in); //open a file to perform read operation using file object
		if (newfile.is_open()) {   //checking whether the file is open


			while (getline(newfile, tp[i])) { //read data from file object and put it into string.
		 //   cout << tp[i] << "\n"; //print the data of the string
				i++;
			}
			newfile.close(); //close the file object.
		}
		return tp;
	}

	int count(string n)
	{

		string line;   // To read each line from code
		int count = 0;    // Variable to keep count of each line
		ifstream mFile;
		mFile.open(n);
		if (mFile.is_open())
			while (mFile.peek() != EOF)
			{
				getline(mFile, line);
				count++;
			}
		mFile.close();
		return count;

	}

	void WriteToFile(string* s, string filename) 
	{
		fstream newfile;
		newfile.open(filename);  // open a file to perform write operation using file object
		for (int i = 0; i < count(filename); i++) {
			newfile << s[i] << '\n';

		}
	}

	void UpdateUnits(string ID, int regularUnits, int peakUnits)
	{
		fstream f;
		string* s = Store("CustomerInfo.txt");
		f.open("CustomerInfo.txt");

		if (!(f))
			cout << "Cant;";
		
		bool flag = true;
		for (int i = 0; i < count("CustomerInfo.txt"); i++)
		{
			flag = true;
			int j;
			for (j = 0; j < 4; j++)
			{
				if (ID[j] != s[i][j])
				{
					flag = false;
				}

			}
			int temp = 0;
			char totalRegularUnits[100], totalPeakUnits[100];
			if (flag)
			{

				for (int k = 0;; k++)
				{
					if (s[i][k] == ',')
					{
						temp++;
					}
					if (temp == 8)
					{
						int regidx = 0;
						k++;
						while (s[i][k] != ',')// for total storing regular units
						{
							totalRegularUnits[regidx] = s[i][k];
							regidx++;
							k++;
						}
						totalRegularUnits[regidx] = '\0';
						k++;
						int peakidx = 0;
						while (s[i][k] != '\0')// for storing total peak units
						{
							totalPeakUnits[peakidx] = s[i][k];
							peakidx++;
							k++;
						}
						totalPeakUnits[peakidx] = '\0';
						break;
					}

				}
				int unit1 = atoi(totalRegularUnits);
				int unit2 = atoi(totalPeakUnits);

				int totalRegularUnitConsumed = unit1 + regularUnits;
				int totalPeakunitsConsumed = unit2 + peakUnits;

				string totalUnits1 = to_string(totalRegularUnitConsumed);
				string totalUnits2 = to_string(totalPeakunitsConsumed);

				int temporary = 0;
				temp = 0;

				for (temporary = 0;; temporary++)
				{
					if (s[i][temporary] == ',')
					{
						temp++;
					}
					if (temp == 8)
					{
						temporary++;
						int check1 = 0;
						while (totalUnits1[check1] != '\0')// for total storing regular units int the file
						{
							s[i][temporary] = totalUnits1[check1];
							check1++;
							temporary++;
						}
						s[i][temporary] = ',';
						temporary++;
						int check2 = 0;

						while (totalUnits2[check2] != '\0')// for total storing peak units int the file
						{
							s[i][temporary] = totalUnits2[check2];
							check2++;

							temporary++;
						}
						s[i][temporary] = '\0';
						break;
					}

				}
				if (flag)
					break;

			}
		}
		if (flag)
		{
			WriteToFile(s, "CustomerInfo.txt");
			cout << "Units updated succesfully\n";
		}
		else
			cout << "\n\n Billing Month Not Found\n\n ";
	}

	void Paid(string customerid, string month)
	{
		fstream f;
		string* s = Store("BillingInfo.txt");

		f.open("BillingInfo.txt"); //bill status file here

		bool flag = true, flag2 = true, temp = true, temp2 = true, check = true;
		int len = count("BillingInfo.txt") - 1;

		for (int i = 0; i < count("BillingInfo.txt"); i++)
		{
			flag = true;
			flag2 = true;
			int j;
			for (j = 0; j < 4; j++)
			{

				if (customerid[j] != s[i][j])
					flag = false;
		
			}
			j++;
			int mon_idx = 0;
			while (s[i][j] != ',')// for checking month
			{
				if (month[mon_idx] != s[i][j])
				{
					flag2 = false;
					break;
				}
				j++;
				mon_idx++;
			}
			j++;
			char regUnits[7];
			int regidx = 0;
			while (s[i][j] != ',')// for storing regular units
			{
				regUnits[regidx] = s[i][j];
				regidx++;
				j++;
			}
			regUnits[regidx] = '\0';
			j++;
			char peakUnits[7];
			int peakidx = 0;
			while (s[i][j] != ',')// for storing peak units
			{
				peakUnits[peakidx] = s[i][j];
				peakidx++;
				j++;
			}
			peakUnits[peakidx] = '\0';
			int reg = atoi(regUnits);
			int peak = atoi(peakUnits);

			int faltu = 0;
			if (flag && flag2)
			{
				for (int k = 0;; k++)
				{
					if (s[i][k] == ',')
					{
						faltu++;
					}
					if (faltu == 9)
					{
						if (s[i][k + 1] == 32)
						{
							cout << "Bill already paid\n";
							temp = false;
							break;
						}

						s[i][k + 1] = ' ';
						s[i][k + 2] = 'P';
						s[i][k + 3] = 'A';
						s[i][k + 4] = 'I';
						s[i][k + 5] = 'D';
						s[i][k + 6] = ' ';
						UpdateUnits(customerid, reg, peak);
						check = false;
						break;
					}

				}
				if (!(temp))
					break;
				if (!(check))
					break;
			}
			if (i == len && !(flag && flag2))
				temp2 = false;
		}
		if (temp && temp2)
		{
			WriteToFile(s, "BillingInfo.txt");
			cout << "\n\ Bill Status changed succesfully\n";
		}
		else if (!(temp2))
			cout << "\n\ Billing Month Not Found In LESCO BILLING RECORD \n\\n";
	}

	void Update()
	{
		ID_check("BillingInfo.txt");

		cout << " \n Billing Month: ";
		do {
			cin >> Imonth;
		} while (Imonth < 0 || Imonth > 12);
		Imonth += 1;

		Paid(to_string(idNum), getMonth());

		Sleep(450);
		system("cls");
	}
};

class BillingSystem
	: public Employee
{
private:

	int BillAmount;
	string DueDate;
	bool status;
	string BillStatus;

public:

	BillingSystem()
	{
		DueDate = '\0';
		status = 0;
		BillAmount = 0;
		BillStatus = '\0';
	}

	void BillingInfo()
	{
		Employee::ID_check("CustomerInfo.txt");
		BillAmount = Employee::GenerateBill();
		status = Employee::ChangeStatus();

		if (status)
			BillStatus = "PAID";
		else
			BillStatus = "UNPAID";

		Due();

		fstream billFile;

		billFile.open("BillingInfo.txt", ios::out | ios::app);

		billFile << Employee::idNum << "," << Employee::getMonth() << "," << Customer::Regular_units << ","
			<< Customer::Peak_units << "," << Employee::IssuanceDate<< ","<<Employee::ECost << "," << Employee::Tax
			<< "," << Employee::Charges << "," << Employee::BCost<<","<<BillStatus<<","<<DueDate<<"   "<<"\n";

		billFile.close();

		system("cls");
	}

	void Due()
	{
		DueDate = to_string(Iday + 7) + "/" + to_string(Imonth) + "/" + to_string(Iyear);
	}

	void CSignIn()
	{  
		bool flag = false;

		cout << "\n Enter UserName: ";
		getline(cin,Customer::Username);

		int num = stoi(Customer::Username);


		if (Employee::checkID("CustomerInfo.txt", num))
			flag = true;

		cout << " \n Enter Password: ";

		char var;
		int idx = 0;

		for (int i = 0; 1; i++)
		{
			var = _getch();
			if (var == 13)
				break;
			if (var >= 32 && var <= 126)
			{
				Customer::Password[idx] = var;
				cout << " * ";
				idx++;
			}
		}
		Customer::Password[idx] = '\0';

		if (flag)
		{  
			string loop;
			char temp[10], code[15];
			fstream infile;
			infile.open("CustomerInfo.txt", ios::in);

			for (int i = 0; i < Row - 1; i++)
				getline(infile, loop);

			infile.getline(temp, 10, ',');
			infile.getline(code, 14, ',');
			code[14] = '\0';

			infile.close();

			if (strcmp(code, Customer::Password) == 0)
				flag = true;
			else
				flag = false;
			
		}
		if (flag)
		{

			cout << "\n\n Successfully Logged In \n";

			Sleep(600);
			system("cls");
		}
		else
		{
			cout << "\n\n  XXX UserName (or) Password is Incorrect XXX " << endl;
			Sleep(800);
			system("cls");
			CSignIn();
		}
	}

	void PrintBill( string ID , string month)
	{
		fstream f;
		string* s = Store("BillingInfo.txt");

		f.open("BillingInfo.txt"); //bill status file here

		bool flag = true, flag2 = true;
		int row = 0;

		for (int i = 0; i < count("BillingInfo.txt"); i++)
		{
			flag = true;
			flag2 = true;

			int j;
			for (j = 0; j < 4; j++)
			{
				if (ID[j] != s[i][j])
					flag = false;

			}
			j++;
			int mon_idx = 0;
			while (s[i][j] != ',')// for checking month
			{
				if (month[mon_idx] != s[i][j])
				{
					flag2 = false;
					break;
				}
				j++;
				mon_idx++;
			}
			if (flag && flag2)
			{
				Row = i + 1;
				break;
			}
			
		}

		if (flag && flag2)
		{
			fstream fin;

			fin.open("BillingInfo.txt", ios::in);

			string line;
			char temp[50];
			int size = 0;

			for (int i = 0; i < Row - 1; i++)
				getline(fin, line);

			fin.getline(temp, 20, ',');

			string S = Convert_To_String(temp, 4);

			idNum = stoi(S);

			temp[0] = '\0';
			fin.getline(temp, 20, ',');
			
			string BMonth = month;

			temp[0] = '\0';

			fin.getline(temp, 20, ',');
			size = strlen(temp);
			S = Convert_To_String(temp, size);

			Customer::Regular_units = stoi(S);
			
			
			temp[0] = '\0';

			fin.getline(temp, 20, ',');
			size = strlen(temp);
			S = Convert_To_String(temp, size);

			Customer::Peak_units = stoi(S);
			
			temp[0] = '\0';

			fin.getline(temp, 20, ',');
			size = strlen(temp);
			S = Convert_To_String(temp, size);

			Employee::IssuanceDate = S;
			
			temp[0] = '\0';

			fin.getline(temp, 20, ',');
			size = strlen(temp);
			S = Convert_To_String(temp, size);

			Employee::ECost = stoi(S);
			

			temp[0] = '\0';
			fin.getline(temp, 20, ',');
			size = strlen(temp);
			S = Convert_To_String(temp, size);

			Employee::Tax = stod(S);

			temp[0] = '\0';
			fin.getline(temp, 20, ',');
			size = strlen(temp);
			S = Convert_To_String(temp, size);

			Employee::Charges = stoi(S);
			

			temp[0] = '\0';
			fin.getline(temp, 20, ',');
			size = strlen(temp);
			S = Convert_To_String(temp, size);

			Employee::BCost = stoi(S);
			

			temp[0] = '\0';
			fin.getline(temp, 20, ',');
			size = strlen(temp);
			S = Convert_To_String(temp, size);

			BillStatus = S;

			temp[0] = '\0';
			fin.getline(temp, 20, ',');
			size = strlen(temp);
			S = Convert_To_String(temp, size);

			DueDate = S;

			fin.close();

			fstream file;

			temp[0] = '\0';

			file.open("CustomerInfo.txt", ios::in);

			Employee::checkID("CustomerInfo.txt", stoi(ID));

			for (int i = 0; i < Row - 1; i++)
				getline(file, line);

			file.getline(temp, 20, ',');
			temp[0] = '\0';

			file.getline(temp, 20, ',');
			
			for (int i = 0; i < 13; i++)
				Customer::CNIC[i] = temp[i];
			CNIC[12] = '\0';
			string name;
			temp[0] = '\0';
			file.getline(temp, 50, ',');
			size = strlen(temp);
			name = Convert_To_String(temp, size);

			Customer::customerName = name;

			temp[0] = '\0';
			file.getline(temp, 50, ',');
			size = strlen(temp);
			S = Convert_To_String(temp, size);

			Customer::customerAddress = S;

			temp[0] = '\0';

			file.getline(temp, 20, ',');

			for (int i = 0; i < 11; i++)
				Customer::Phone[i] = temp[i];
			Phone[11] = '\0';
			
			temp[0] = '\0';
			file.getline(temp, 20, ',');
			size = strlen(temp);
			Customer::customerType = Convert_To_String(temp, size);


			temp[0] = '\0';
			file.getline(temp, 20, ',');
			size = strlen(temp);
			Customer::MeterType = Convert_To_String(temp, size);


			file.close();

			cout << "\n\n\t\t L E S C O   B I L L \n\n";

			cout << "\n\n\t  Customer ID: " << idNum;
			cout << "\n\n\t  Billing Month: " << BMonth;
			cout << "\n\n\t  Issuance Date: " << IssuanceDate;
			cout << "\n\n\t  Customer Name: " << /*Customer::customerName*/ name;
			cout << "\n\n\t  Customer CNIC: " << CNIC;
			cout << "\n\n\t  Customer Phone N.O: " << Phone;
			cout << "\n\n\t  Customer Address " << Customer::customerAddress;
			cout << "\n\n\t  Customer Type: " << Customer::customerType;
			cout << "\n\n\t  Meter Type: " << Customer::MeterType;
			cout << "\n\n\t  Regular Units Consumed: " << Customer::Regular_units;
			cout << "\n\n\t  Peak Units Consumed:" << Customer::Peak_units;
			cout << "\n\n\t  Electricity Cost " << Employee::ECost;
			cout << "\n\n\t  Tax Cost: " << Employee::Tax;
			cout << "\n\n\t  Fixed Charges: " << Employee::Charges;
			cout << "\n\n\t  Total Bill Amount: " << Employee::BCost;
			cout << "\n\n\t  Due Date: " << DueDate;

			
			_getch();
			system("cls");
		}
		else
		{
			cout << "\n\n Billing Month Not Found";
			Sleep(500);
		}

		system("cls");
	}

	void EPrint()
	{
		ID_check("BillingInfo.txt");

		cout << " \n Billing Month: ";
		do {
			cin >> Imonth;
		} while (Imonth < 0 || Imonth > 12);
		Imonth += 1;

		PrintBill(to_string(idNum), getMonth());
	}
	void CPrint()
	{  
		idNum  = stoi(Customer::Username);

		cout << " \n Billing Month: ";
		do {
			cin >> Imonth;
		} while (Imonth < 0 || Imonth > 12);
		Imonth += 1;

		system("cls");

		PrintBill(to_string(idNum), getMonth());
	}
};


int Customer::customerID = 0;
int Customer::month = 0;
int Customer::meters = 0;
bool Customer::Check = 0;
int Employee::Imonth = 0;
int Employee::Iyear = 0;
int Employee::Iday = 0;
int Employee::Row = 0;



int main()
{
	instructions();
	_getch();
	system("cls");

	Employee admin;
	BillingSystem C1, Bill;

	cout << "\n Sign In as Employee [ 1 ]  \n\n Sign In as Customer [ 2 ] ";

	do
	{
		temp = _getch();

	} while (temp < 49 || temp > 50);

	system("cls");



	switch (int(temp) - 48)
	{
	case 1:
		admin.SignIn();
		check = 1;
		break;
	case 2:
		C1.CSignIn();
		check = 0;
		break;
	default:
		check = -1;
		break;
	}
	
		if (check)
		{
			do
			{
				cout << "\n\n\t\t  Add a New Customer        [ 1 ] \n";
				cout << "\n\n\t\t  Generate Electricity Bill [ 2 ] \n";
				cout << "\n\n\t\t  Change Billing Status     [ 3 ] \n";
				cout << "\n\n\t\t  Change Tax & Tarrif       [ 4 ] \n";
				cout << "\n\n\t\t  Change Password of Admin  [ 5 ] \n";
				cout << "\n\n\t\t  View Customers Bill       [ 6 ] \n";
				cout << "\n\n\t\t  Exit                      [ 0 ] \n";

				do
				{
					temp = _getch();

				} while (temp < 48 || temp > 54);

				switch (int(temp) - 48)
				{
				case 1:
					system("cls");
					admin.RegisterNewMeter();
					system("cls");
					break;
				case 2:
					system("cls");
					Bill.BillingInfo();
					break;
				case 3:
					system("cls");
					admin.Update();
					break;
				case 4:
					system("cls");
					admin.ChangeTaxInfo();
					system("cls");
					break;
				case 5:
					system("cls");
					admin.ChangePassword();
					break;
				case 6:
					system("cls");
					C1.EPrint();
					break;
				case 0:
					exit(0);
					break;
				default:
					check = -1;
					break;
				}
			} while (temp > 48 && temp < 55);

		}
		else if (!check)
		{
			do {

				cout << "\n\n  View Bill  [ 1 ] \n";
				cout << "\n\n  Exit       [ 0 ] \n";
				do
				{
					temp = _getch();
				}
			   while (temp < 48 || temp > 49);

				switch (int(temp) - 48)
				{
				case 1:
					system("cls");
					C1.CPrint();
					break;
				case 2:
					system("cls");
					exit(0);
					break;

				}
			} while (temp > 48 && temp < 50);
		}
	    
	return 0;
}