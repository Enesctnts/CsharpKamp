#include<iostream>
using namespace std;

class Daire
{
    private:
        double pi = 3.14;
    public:
        double r;
    double alan( double r)
    {
        return pi*r*r;
    }
    double cevre ( double r)
    {
        return 2*pi*r;
    }
 
};

int main()
{
    Daire d1;
    cout << "Yaricapi giriniz: "; cin >> d1.r ;
    cout << "Dairenin alani  : " << d1.alan( d1.r ) << endl;
    cout << "Dairenin cevresi: " << d1.cevre( d1.r ) << endl;

    system("pause");
    return 0;
}
