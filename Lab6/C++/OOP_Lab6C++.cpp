

#include <iostream>
#include "Problem.h"
#include <stdexcept>
using namespace std;
bool CheckIndex(int,int);
const int length = 10;
int main()
{
    Problem p1(4,2,7);
    Problem p2(2,3,4);
    //double t = p1 * 2;
    Problem problems[length];
    for (int i = 0; i < length;i++ ) {
        try {
            CheckIndex(i, length);
            problems[i] = p2;
        }
        catch(runtime_error & e){
            cout << "Exception occurred" << endl
                << e.what();
        }   
    }
    cout << "problems[0]:"<<problems[0]*3<<endl;
    cout << "problems[1]:"<<problems[1]*2<<endl;
    cout << "problems[2]:"<<problems[2]*4<<endl;
    cout << "problems[3]:"<<problems[3]*1<<endl;
    cout << "problems[4]:"<<problems[2]*5<<endl;
}
bool CheckIndex(int index,int length) {
    if (index >= length)throw runtime_error("out of range ");
    return true;
}


