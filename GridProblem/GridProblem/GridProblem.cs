using System;

public class GridProblem
{
	static bool bResult { get; set; }

	public bool Grid(char[][] board, string strWord)
	{
		GetFirstLetter(board, strWord);
		return bResult;
	}

	private static void GetFirstLetter(char[][] board, string strWord)
	{
		int nRowCount = board.Length;
		int nColCount = board[0].Length;

		for(int i = 0; i < nRowCount; i++)
		{
			for(int j = 0; j < nColCount; j++)
			{
				if(board[i][j] == strWord[0])
				{
					FindAdjacent(i, j, board, strWord, 1);
					if(bResult) return;
				}
			}
		}
	}

	private static void FindAdjacent(int nRow, int nCol, char[][] board, string strWord, int nIndex)
	{
		if(nIndex == strWord.Length)
		{
			bResult = true;
			return;
		}

		int rowCount = board.Length;
		int colCount = board[0].Length;

		// Top
		if(nRow > 0 && board[nRow - 1][nCol] == strWord[nIndex])
			FindAdjacent(nRow - 1, nCol, board, strWord, nIndex + 1);

		// Bottom
		if(nRow < rowCount - 1 && board[nRow + 1][nCol] == strWord[nIndex])
			FindAdjacent(nRow + 1, nCol, board, strWord, nIndex + 1);

		// Left
		if(nCol > 0 && board[nRow][nCol - 1] == strWord[nIndex])
			FindAdjacent(nRow, nCol - 1, board, strWord, nIndex + 1);

		// Right
		if(nCol < colCount - 1 && board[nRow][nCol + 1] == strWord[nIndex])
			FindAdjacent(nRow, nCol + 1, board, strWord, nIndex + 1);
	}
}