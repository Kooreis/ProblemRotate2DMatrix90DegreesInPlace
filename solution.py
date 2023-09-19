Here is a Python console application that rotates a 2D matrix by 90 degrees in-place:

```python
def rotate(matrix):
    n = len(matrix)
    for i in range(n // 2):
        for j in range(i, n - i - 1):
            temp = matrix[i][j]
            matrix[i][j] = matrix[n - 1 - j][i]
            matrix[n - 1 - j][i] = matrix[n - 1 - i][n - 1 - j]
            matrix[n - 1 - i][n - 1 - j] = matrix[j][n - 1 - i]
            matrix[j][n - 1 - i] = temp

def print_matrix(matrix):
    for row in matrix:
        print(row)

def main():
    matrix = [[1, 2, 3], [4, 5, 6], [7, 8, 9]]
    print("Original Matrix:")
    print_matrix(matrix)
    rotate(matrix)
    print("Rotated Matrix:")
    print_matrix(matrix)

if __name__ == "__main__":
    main()
```

When you run this program, it will print the original matrix, rotate it by 90 degrees, and then print the rotated matrix. The `rotate` function performs the rotation in-place, meaning it modifies the original matrix instead of creating a new one.