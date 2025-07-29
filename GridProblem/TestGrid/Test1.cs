namespace TestGrid
{
	[TestClass]
	public sealed class Test1
	{
		[TestMethod]
		public void TestMethod1()
		{
			char[][] board = {
					['A','B','C','E'],
					['S','F','C','S'],
					['A','D','E','E']
				};
			string strWord = "ABCCED";
			GridProblem gridProblem = new GridProblem();
			bool bResult = gridProblem.Grid(board, strWord);
			Assert.AreEqual(true, bResult);
		}

		[TestMethod]
		public void TestMethod2()
		{
			char[][] board = {
					['A','B','C','E'],
					['S','F','C','S'],
					['A','D','E','E']
				};
			string strWord = "ABCED";
			GridProblem gridProblem = new GridProblem();
			bool bResult = gridProblem.Grid(board, strWord);
			Assert.AreEqual(false, bResult);
		}

	}
}
