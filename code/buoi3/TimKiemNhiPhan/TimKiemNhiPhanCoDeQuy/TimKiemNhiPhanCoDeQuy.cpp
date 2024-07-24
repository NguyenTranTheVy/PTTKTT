#include <stdio.h>

// Hàm tìm kiếm nhị phân không đệ quy
int binarySearchNonRecursive(int arr[], int size, int target) {
	int low = 0;
	int high = size - 1;

	while (low <= high) {
		int mid = low + (high - low) / 2;

		if (arr[mid] == target) {
			return mid; // Phần tử tìm thấy
		}
		if (arr[mid] < target) {
			low = mid + 1; // Tìm kiếm trong nửa bên phải
		}
		else {
			high = mid - 1; // Tìm kiếm trong nửa bên trái
		}
	}

	return -1; // Phần tử không tồn tại
}

int main() {
	int arr[] = { 10, 7, 8, 9, 1, 5 }; // Mảng đã được sắp xếp
	int size = sizeof(arr) / sizeof(arr[0]);
	int target;

	printf("Nhap phan tu can tim: ");
	scanf("%d", &target);

	int result = binarySearchNonRecursive(arr, size, target);

	if (result != -1) {
		printf("Phan tu %d duoc tim thay tai chi so %d\n", target, result);
	}
	else {
		printf("Phan tu %d khong ton tai trong mang\n", target);
	}

	return 0;
}