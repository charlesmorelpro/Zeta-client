   M S B A M L   `   `   `  ���� E  AZetaClient, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:ZetaClient.pagesZetaClient.pages  &     ZetaClient.pages.IngredientsPage   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     0localclr-namespace:ZetaClient.pages     -     N� Title$  IngredientsPage��.���  � RowDefinitions �� $
��Auto ��� $��* �.+��� $��0��$��Ingrédients��$��Center=�$��18(�� $��1��
������� � ColumnDefinitions �� $
��Auto ��� $��* � �� $
��Auto ��� $��* �.+�]� $��1��$��Right=�.+��� $��1��$��
Rechercher���� -    ��Name$ SearchTextBox��$��1��$��Right=�$	��160��$��10, 0q�$��Center=�$��4q�� $��1��$��0��$	��250��$	��250��$	��Top=�$��10q� �� $
��Auto ��� $��* � �� $
��Auto ��� $��* ��� $
��Auto �.+��� $	��Nom���� -   $ 	NameInput��$��1��$��0,0,0,10q�$��4q��� $��1��$��Description���� -   $ DescriptionInput��$��1��$��1��$��0,0,0,10q�$��4q��� -    ��Name$ 	AddButton��$��2��$��1��$��4q�$��Right=�.��	Ajouter&   System.Windows.Controls.DataGrid  -   $��IngDataGrid��$��1��$��1��   AutoGenerateColumns .     
IsReadOnly . $��10q�   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$
 Auto 	   Header$
	 Name��1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 �� *Name+  $ * $	 Description��
 �� *Description+4  .System.Windows.Controls.DataGridTemplateColumn  $
 Auto $	 Modifier��   CellTemplate �� .R��� -   $��Modify��  $
 Auto $	 	Supprimer�� �� .R��� -   $��Delete��� -	    �Name$ ModifyPopup��$��Center=�$	��400��$	��350��.���� $��1q�._�� 
������� �� $
��Auto ��� $��* �.+��� $��16(�$��DemiBold"�$��Center=�$��Center=�$��Modifier le Processus���� -
   $��CloseModifyPopupButton��$��X��$
��Bold"�$��4q�$��Right=� � Cursor$
 Hand��� $��1��$��20q� �� $
��Auto ��� $��* � �� $
��Auto ��� $��* ��� $
��Auto �.+��� $	��Nom���� -   $ ModifyNameInput��$��1��$��Center=��� $��1��$��Description���� -   $ ModifyDescriptionInput��$��1��$��1���� -   $ ModifyValidationButton��$��0,10,0,0q�$��1��$��3��$��Right=�$
��8, 4q�.��
Modifier