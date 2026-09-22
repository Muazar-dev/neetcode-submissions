public class Solution {

public int gettable(int i, int j) {
    int table;
                if(i <= 2) {
                    if(j <= 2) {
                    table = 0;
                }
                else if(j <=5) {
                    table = 1;
                }
                else {
                    table = 2;
                }


                }


                else if(i <=5) {
                     if(j <= 2) {
                    table = 3;
                }
                else if(j <=5) {
                    table = 4;
                }
                else {
                    table = 5;
                }

                }
                else {
                     if(j <= 2) {
                    table = 6;
                }
                else if(j <=5) {
                    table = 7;
                }
                else {
                    table = 8;
                }

                }
                return table;
}

    public bool IsValidSudoku(char[][] board) {
        List<HashSet<char>> rows = new List<HashSet<char>>(9);
        List<HashSet<char>> columns = new List<HashSet<char>>(9);
        List<HashSet<char>> tables = new List<HashSet<char>>(9);

        for(int i = 0; i < 9; i++) {
            rows.Add(new HashSet<char>());
            columns.Add(new HashSet<char>());
            tables.Add(new HashSet<char>());
        }
        


        for(int i = 0; i < board.Length; i++) {
            for(int j = 0; j < board.Length; j++) {
                if(board[i][j] == '.')
                {
                    continue;
                }
                if(rows[i].Contains(board[i][j]) || columns[j].Contains(board[i][j])) {
                    return false;
                }
                int table = gettable(i, j);

                if(tables[table].Contains(board[i][j])) {
                    return false;
                }


                tables[table].Add(board[i][j]);
                rows[i].Add(board[i][j]);
                columns[j].Add(board[i][j]);


                
            }
        }
        
        return true;
    }
}
