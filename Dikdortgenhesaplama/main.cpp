#include<iostream>
using namespace std;

class Dikdortgen
{

public:
    int uzunluk,genislik;
    int alan(int u, int g)
    {
        return u*g;
    }
};
int main()
{
    Dikdortgen d1;
    cout << "Dikdortgenin uzunugunu giriniz: ";           cin >> d1.uzunluk  ;
    cout << endl << "Dikdortgenin genisligini giriniz: "; cin >> d1.genislik ;
    cout << endl << "Dikdortgenin alani: " << d1.alan( d1.uzunluk , d1.genislik) << endl ;

    system("pause");
    return 0;
}
