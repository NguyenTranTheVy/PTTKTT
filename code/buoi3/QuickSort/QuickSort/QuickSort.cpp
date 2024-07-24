#include <stdio.h>

// Hàm đổi chỗ hai phần tử
void swap(int *a, int *b) {
	int temp = *a;
	*a = *b;
	*b = temp;
}

// Hàm phân hoạch (Partition)
int partition(int arr[], int low, int high) {
	int pivot = arr[high]; // Chọn phần tử cuối cùng làm pivot
	int i = (low - 1); // Chỉ số của phần tử nhỏ hơn

	for (int j = low; j < high; j++) {
		if (arr[j] < pivot) {
			i++;
			swap(&arr[i], &arr[j]);
		}
	}
	swap(&arr[i + 1], &arr[high]);
	return (i + 1);
}

// Hàm QuickSort đệ quy
void quickSort(int arr[], int low, int high) {
	if (low < high) {
		// Phân hoạch
		int pi = partition(arr, low, high);

		// Sắp xếp các phần tử trước và sau phần tử phân hoạch
		quickSort(arr, low, pi - 1);
		quickSort(arr, pi + 1, high);
	}
}

// Hàm in mảng
void printArray(int arr[], int size) {
	for (int i = 0; i < size; i++) {
		printf("%d ", arr[i]);
	}
	printf("\n");
}

int main() {
	int arr[6] = {  7, 6, 19, 13, 20, 17 }; // Mảng 6 phần tử
	int n = sizeof(arr) / sizeof(arr[0]);

	printf("Mang truoc khi sap xep:\n");
	printArray(arr, n);

	// Thực hiện QuickSort
	quickSort(arr, 0, n - 1);

	printf("Mang sau khi sap xep:\n");
	printArray(arr, n);

	return 0;
}
