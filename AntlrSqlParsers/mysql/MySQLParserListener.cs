//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.5.3
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from grammars/MySQLParser.g4 by ANTLR 4.5.3

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="MySQLParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.5.3")]
[System.CLSCompliant(false)]
public interface IMySQLParserListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySQLParser.stat"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStat([NotNull] MySQLParser.StatContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySQLParser.stat"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStat([NotNull] MySQLParser.StatContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySQLParser.schema_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSchema_name([NotNull] MySQLParser.Schema_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySQLParser.schema_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSchema_name([NotNull] MySQLParser.Schema_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySQLParser.select_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSelect_clause([NotNull] MySQLParser.Select_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySQLParser.select_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSelect_clause([NotNull] MySQLParser.Select_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySQLParser.table_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTable_name([NotNull] MySQLParser.Table_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySQLParser.table_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTable_name([NotNull] MySQLParser.Table_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySQLParser.table_alias"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTable_alias([NotNull] MySQLParser.Table_aliasContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySQLParser.table_alias"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTable_alias([NotNull] MySQLParser.Table_aliasContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySQLParser.column_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterColumn_name([NotNull] MySQLParser.Column_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySQLParser.column_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitColumn_name([NotNull] MySQLParser.Column_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySQLParser.column_name_alias"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterColumn_name_alias([NotNull] MySQLParser.Column_name_aliasContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySQLParser.column_name_alias"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitColumn_name_alias([NotNull] MySQLParser.Column_name_aliasContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySQLParser.index_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIndex_name([NotNull] MySQLParser.Index_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySQLParser.index_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIndex_name([NotNull] MySQLParser.Index_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySQLParser.column_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterColumn_list([NotNull] MySQLParser.Column_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySQLParser.column_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitColumn_list([NotNull] MySQLParser.Column_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySQLParser.column_list_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterColumn_list_clause([NotNull] MySQLParser.Column_list_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySQLParser.column_list_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitColumn_list_clause([NotNull] MySQLParser.Column_list_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySQLParser.from_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFrom_clause([NotNull] MySQLParser.From_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySQLParser.from_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFrom_clause([NotNull] MySQLParser.From_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySQLParser.select_key"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSelect_key([NotNull] MySQLParser.Select_keyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySQLParser.select_key"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSelect_key([NotNull] MySQLParser.Select_keyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySQLParser.where_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWhere_clause([NotNull] MySQLParser.Where_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySQLParser.where_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWhere_clause([NotNull] MySQLParser.Where_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySQLParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpression([NotNull] MySQLParser.ExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySQLParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpression([NotNull] MySQLParser.ExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySQLParser.element"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterElement([NotNull] MySQLParser.ElementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySQLParser.element"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitElement([NotNull] MySQLParser.ElementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySQLParser.right_element"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRight_element([NotNull] MySQLParser.Right_elementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySQLParser.right_element"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRight_element([NotNull] MySQLParser.Right_elementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySQLParser.left_element"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLeft_element([NotNull] MySQLParser.Left_elementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySQLParser.left_element"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLeft_element([NotNull] MySQLParser.Left_elementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySQLParser.target_element"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTarget_element([NotNull] MySQLParser.Target_elementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySQLParser.target_element"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTarget_element([NotNull] MySQLParser.Target_elementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySQLParser.relational_op"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRelational_op([NotNull] MySQLParser.Relational_opContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySQLParser.relational_op"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRelational_op([NotNull] MySQLParser.Relational_opContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySQLParser.expr_op"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpr_op([NotNull] MySQLParser.Expr_opContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySQLParser.expr_op"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpr_op([NotNull] MySQLParser.Expr_opContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySQLParser.between_op"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBetween_op([NotNull] MySQLParser.Between_opContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySQLParser.between_op"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBetween_op([NotNull] MySQLParser.Between_opContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySQLParser.is_or_is_not"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIs_or_is_not([NotNull] MySQLParser.Is_or_is_notContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySQLParser.is_or_is_not"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIs_or_is_not([NotNull] MySQLParser.Is_or_is_notContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySQLParser.simple_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSimple_expression([NotNull] MySQLParser.Simple_expressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySQLParser.simple_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSimple_expression([NotNull] MySQLParser.Simple_expressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySQLParser.table_references"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTable_references([NotNull] MySQLParser.Table_referencesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySQLParser.table_references"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTable_references([NotNull] MySQLParser.Table_referencesContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySQLParser.table_reference"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTable_reference([NotNull] MySQLParser.Table_referenceContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySQLParser.table_reference"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTable_reference([NotNull] MySQLParser.Table_referenceContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySQLParser.table_factor1"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTable_factor1([NotNull] MySQLParser.Table_factor1Context context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySQLParser.table_factor1"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTable_factor1([NotNull] MySQLParser.Table_factor1Context context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySQLParser.table_factor2"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTable_factor2([NotNull] MySQLParser.Table_factor2Context context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySQLParser.table_factor2"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTable_factor2([NotNull] MySQLParser.Table_factor2Context context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySQLParser.table_factor3"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTable_factor3([NotNull] MySQLParser.Table_factor3Context context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySQLParser.table_factor3"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTable_factor3([NotNull] MySQLParser.Table_factor3Context context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySQLParser.table_factor4"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTable_factor4([NotNull] MySQLParser.Table_factor4Context context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySQLParser.table_factor4"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTable_factor4([NotNull] MySQLParser.Table_factor4Context context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySQLParser.table_atom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTable_atom([NotNull] MySQLParser.Table_atomContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySQLParser.table_atom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTable_atom([NotNull] MySQLParser.Table_atomContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySQLParser.join_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterJoin_clause([NotNull] MySQLParser.Join_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySQLParser.join_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitJoin_clause([NotNull] MySQLParser.Join_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySQLParser.join_condition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterJoin_condition([NotNull] MySQLParser.Join_conditionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySQLParser.join_condition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitJoin_condition([NotNull] MySQLParser.Join_conditionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySQLParser.index_hint_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIndex_hint_list([NotNull] MySQLParser.Index_hint_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySQLParser.index_hint_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIndex_hint_list([NotNull] MySQLParser.Index_hint_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySQLParser.index_options"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIndex_options([NotNull] MySQLParser.Index_optionsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySQLParser.index_options"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIndex_options([NotNull] MySQLParser.Index_optionsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySQLParser.index_hint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIndex_hint([NotNull] MySQLParser.Index_hintContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySQLParser.index_hint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIndex_hint([NotNull] MySQLParser.Index_hintContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySQLParser.index_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIndex_list([NotNull] MySQLParser.Index_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySQLParser.index_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIndex_list([NotNull] MySQLParser.Index_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySQLParser.partition_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPartition_clause([NotNull] MySQLParser.Partition_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySQLParser.partition_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPartition_clause([NotNull] MySQLParser.Partition_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySQLParser.partition_names"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPartition_names([NotNull] MySQLParser.Partition_namesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySQLParser.partition_names"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPartition_names([NotNull] MySQLParser.Partition_namesContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySQLParser.partition_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPartition_name([NotNull] MySQLParser.Partition_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySQLParser.partition_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPartition_name([NotNull] MySQLParser.Partition_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySQLParser.subquery_alias"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSubquery_alias([NotNull] MySQLParser.Subquery_aliasContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySQLParser.subquery_alias"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSubquery_alias([NotNull] MySQLParser.Subquery_aliasContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySQLParser.subquery"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSubquery([NotNull] MySQLParser.SubqueryContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySQLParser.subquery"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSubquery([NotNull] MySQLParser.SubqueryContext context);
}
