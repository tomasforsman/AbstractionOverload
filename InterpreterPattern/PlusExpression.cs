public class PlusExpression : IExpression {
	private IExpression leftExpression;
	private IExpression rightExpression;
    
	public PlusExpression(IExpression left, IExpression right) {
		leftExpression = left;
		rightExpression = right;
	}
    
	public int Interpret() {
		return leftExpression.Interpret() + rightExpression.Interpret();
	}
}