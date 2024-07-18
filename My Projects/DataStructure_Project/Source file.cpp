#include <iostream>
#include<chrono>
#include <bits/stdc++.h>


using namespace std;

namespace sortlib
{
    template <class T>
    void insertion (T arr[],int size)
{
	for (int i=1 ; i<size ;i++)
		{
			int temp = arr[i] , j = i ;
			for ( ; j>0 && temp<arr[j-1];)
			{
				arr[j] = arr[j-1] ;
				j-- ;

			}
			arr[j] = temp ;
		}
}
template <class T>
void selection (T arr[] , int size )
{
	for (int i=0 ; i<size-1 ; i++)
	{
		//T minimum = arr[i] ;
		int key = i ;
		for (int j=i+1 ; j<size ; j++ )
		{
			if (arr[j] < arr[key]) //replace:  arr[key] -> minimum
				key = j  ;		   //replace:  minimum -> arr[j] ;
		}
		swap(arr[i],arr[key]) ;    //replace:  arr[key] -> minimum
	}
}
template <class T>
void bubble (T arr[] , int size )
{
	bool flag = true ;
	for (int i=0 ; i<size-1 ; i++ )
		{
		for (int j =0  ;j<size-i-1 ; j++ )
				if (arr[j]>arr[j+1])
				{
					swap(arr[j],arr[j+1]) ;
					flag = false ;
				}
				if (flag)
					break ;
		}
}
template <typename T>
void shell (T arr[] , int size)
{
	for (int gap=size/2 ; gap>0 ; gap/=2)
		for (int i = gap ; i<size ; i++ )
			for (int j=i ; j>=gap ; j-=gap) // y3tbr de msh loop
				if (arr[j]<arr[j-gap])
					swap(arr[j] , arr[j-gap]) ;

}
template <class T >
void countt (T arr[] ,int size )
{
	T max = arr[0] ;
	for (int i=0 ; i<size ; i++)
		if (arr[i]>max)
			max = arr[i] ;

	T arrC[max] ={0};
	for (int i=0 ; i<size ;i++)
		arrC[arr[i]-1]  ++ ; // -1 for 0 based //
	for (int i=1 ; i<max ; i++)
		arrC[i] += arrC[i-1] ;
	T arrB[size] ;
	for (int i=size-1 ; i>=0 ; i--)
		arrB[--arrC[arr[i]-1]] = arr[i] ;	// arrC[arr[i]-1] --> comulative of arr[i] in arrC
											// ba7oto fe mkan el comulative bta3o - 1 fel array el naha2ya
	for (int i=0 ; i<size ; i++)
		arr[i] = arrB[i] ;
}
template <typename T>
void merge(T arr[],int left , int middle , int right) // m = l ( r-l )/2
{
	int size1 = middle - left +1 ;  // we work on 0 based size and if data isn't semitric the extre element will be it left side
	int size2 = right - middle ; // right array
	T arr1[size1] , arr2[size2] ; // non inplace

	for (int i=0 ; i<size1 ; i++)
		arr1[i] = arr[left + i];
	for (int j=0 ; j<size2 ; j++)
		arr2[j] = arr[j+middle+1];

	int i= 0 , j=0 ;
	int k = left ; // begining of my original array
	while (i<size1 && j<size2)
	{
		if (arr1[i]<arr2[j])
			arr[k++] = arr1[i++];
		else
			arr[k++] = arr2[j++] ;
	}
	while (i<size1)
	{
		arr[k++] = arr1[i++] ;
	}
	while (j<size2 )
	{
		arr[k++] = arr2[j++] ;
	}

}
template <typename T>
void mergeSort (T arr[] , int left , int right ) // size-1 (0 based size ) // this for my main is array is 7 elements pass 6 as right
{
	if (left >=right)
		return ;
	else
	{
		int middle = left + (right - left )/2 ;

		mergeSort (arr , left , middle ) ;  //
		mergeSort (arr , middle+1 , right ) ; // 2 recursion functions and when reach the base case function
											  // merge will called

		merge(arr,left, middle ,right) ;
	}
}
template <typename T>
int partition(T arr[] , int left , int right )
{
	T pivot= arr[left] ; // I choosed the first elemrnt to be pivot
	int i = left ;
	for (int j= left + 1 ; j< right ; j++ )
	{
		if (arr[j]<pivot)
		{
			i++ ;
			swap(arr[i],arr[j]) ;
		}

		swap(arr[i], arr[left] );
	}
	return i ;  // i represent position for pivot after sorting it
}
template <typename T>
void quick(T arr[] , int left , int right )
{
	if(left<right)
	{
		int pivot = partition(arr,left,right) ;
		quick (arr,left,pivot-1) ;
		quick (arr , pivot +1 , right ) ;

	}

}
void print (int arr[],int size)
{
	for (int i=0 ;i<size ;i++)
		cout << arr[i]  << " ";
	cout << endl ;
}
}
using namespace sortlib;

int main()

{
    int arr[5]= {5,21,17,1,9};
    insertion(arr,5);
    cout<<"insertion sort :"<<"  ";
     print(arr,5);

     selection(arr,5);
     cout<<"Selection sort :"<<"  ";
    print(arr,5);

    bubble(arr,5);
     cout<<"Bubble sort :"<<"  ";
    print(arr,5);

    shell(arr,5);
     cout<<"shell sort :"<<"  ";
    print(arr,5);

    quick(arr,0,5);
     cout<<"Quick sort :"<<"  ";
    print(arr,5);

    countt(arr,5);
     cout<<"Count sort :"<<"  ";
    print(arr,5);

    mergeSort(arr,0,4);
     cout<<"Merge sort :"<<"  ";
    print(arr,5);

    int randnum;

cout<<"Enter the array size: ";

cin>>randnum;

int Arr[randnum];

srand(time(NULL));

for(int i=0; i<randnum; i++)

{

int rnumber = rand()%5;

Arr[i]= rnumber;

}

/*for(int i=0; i<randnum; i++)

cout<<Arr[i]<<" ";

cout<<endl;*/

    auto start = chrono::high_resolution_clock::now(); // start timer
    quick(Arr,0,randnum);// sort array using the sort function
     print(Arr,randnum);

    auto end = chrono::high_resolution_clock::now(); // end timer
    auto duration = chrono::duration_cast<chrono::milliseconds>(end - start); // calculate duration in milliseconds

    cout << "Sorted array in " << duration.count() << " milliseconds." << endl;

    return 0;
}
