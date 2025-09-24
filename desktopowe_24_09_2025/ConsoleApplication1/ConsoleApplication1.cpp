#include <iostream>
#include <stdio.h>
#include <stdlib.h>
#include <time.h>

#define X 50
#define Y 40
#define Z 27

float rand_temp() {
    return 18.0 + ((float)rand() / RAND_MAX) * 7;
}

using namespace std;
int main() {
    float temp[X][Y][Z];
    srand(time(NULL));

    for (int i = 0; i < X; i++)
        for (int j = 0; j < Y; j++)
            for (int k = 0; k < Z; k++)
                temp[i][j][k] = rand_temp();

    float max_avg = 0.0;
    int index = 0;
    char przekroj = 'a';

    for (int i = 0; i < X; i++)
    {
        float sum = 0.0;
        for (int j = 0; j < Y; j++)
        {
            for (int k = 0; k < Z; k++)
            {
                sum += temp[i][j][k];
            }
        }
        if (sum / (Y * Z) > max_avg)
        {
            max_avg = sum/(Y*Z);
            index = i;
            przekroj = 'X';
        }
    }

    for (int i = 0; i < Y; i++)
    {
        float sum = 0.0;
        for (int j = 0; j < X; j++)
        {
            for (int k = 0; k < Z; k++)
            {
                sum += temp[i][j][k];
            }
        }
        if (sum / (X * Z) > max_avg)
        {
            max_avg = sum/(X*Z);
            index = i;
            przekroj = 'Y';
        }
    }

    cout<<"najwieksza srednia temperatura wynosi: "<<max_avg<<" i wystepuje w przekroju "<<przekroj<<" = "<<index<<endl;
    
    
    
    return 0;
}