   M S B A M L   `   `   `  ���� E  AZetaClient, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:ZetaClient.pagesZetaClient.pages  E'clr-namespace:ZetaClient.Entities.EnumsZetaClient.Entities.Enums  !    ZetaClient.pages.ModelsPage   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     0localclr-namespace:ZetaClient.pages     9enums'clr-namespace:ZetaClient.Entities.Enums     -     N� Title$  
ModelsPage�� � 	Resources  S� 
MethodName S� 
ObjectType)   #ZetaClient.Entities.Enums.RangeType   RangeTypeValues S� MethodParameters M� TypeName��%C   &	        S� $ 	GetValues��"   M� $ enums:RangeType��.���  � RowDefinitions �� $
��Auto ��� $��* �.+��� $��0��$��Modèles��$��Center=�$��18(�� $��1�� � ColumnDefinitions �� $
��Auto ��� $��* � �� $
��Auto ��� $��* �.+�]� $��1��$��Right=�.+��� $��1��$��
Rechercher���� -    ��Name$ SearchTextBox��$��1��$��Right=�$	��160��$��10, 0q�$��Center=�$��4q�� $��0��$��1��$	��250��$	��400��$	��Top=�$��10q� �� $
��Auto ��� $��* � �� $
��Auto ��� $��* ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto �.+��� $	��Nom���� -   $ 	NameInput��$��1��$��0,0,0,10q�$��4q��� $��1��$��Description���� -   $ DescriptionInput��$��1��$��1��$��0,0,0,10q�$��4q��� $��2��$
��pUHT���� -   $ 	pUHTInput��$��2��$��1��$��0,0,0,10q�$��4q��� $��3��$��Gamme���� -   	 ��Name$	 
RangeInput��$��80��$��3��$��1��$��0,0,0,10q�$��4q����� 
 �� Source#
 [  �� $��4��$��Ingrédients���� -   $	 IngredientsListBox��$��4��$��1��$	��100��$��0,0,0,10q�$��4q����� .R���  �� 
IsSelected �� *	IsChecked+.���� -    d� 	IsChecked �� *	IsChecked+����  �� Path$
 Name��� -	    ��Name$ 	AddButton��$��5��$��1��$��4q�$��Right=�.��	Ajouter&   System.Windows.Controls.DataGrid  -
   $��ModelDataGrid��$��1��$��1��   AutoGenerateColumns .     
IsReadOnly . $��10q�   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$
 Auto    Header$
 Name��1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *Name+  $ * $ Description�� �� *Description+  $
 Auto $
 pUHT�� �� *PUHT+  $
 Auto $ Gamme�� �� *Range+4  .System.Windows.Controls.DataGridTemplateColumn  $
 Auto $ Ingrédients��   CellTemplate �� .R��� -   $��Voir ingrédients��  $
 Auto $ Modifier�� �� .R��� -   $��Modify��  $
 Auto $ 	Supprimer�� �� .R��� -   $��Delete��� -    �Name$ IngredientsPopup��$��Center=�$	��500��$	��350��.���� $��1q�._�� 
������� �� $
��Auto ��� $��* �.+��� -    ��Name$ IngPopupTitle��$��16(�$��DemiBold"�$��Center=�$��Center=��� -   $��ClosePopupButton��$��X��$
��Bold"�$��4q�$��Right=� � Cursor$
 Hand��  -   $��IngPopupDataGrid��$��1�� .   . $��10q�   $
 Auto $
 Name�� �� *Ingredient.Name+  $ * $ Description�� �� *Ingredient.Description+  $
 Auto $ Grammage�� �� *
Grammage+� -   $ ModifyPopup��$��Center=�$	��400��$	��350��.���� $��1q�._�� 
������� �� $
��Auto ��� $��* �.+��� $��16(�$��DemiBold"�$��Center=�$��Center=�$��Modifier le modèle���� -   $��CloseModifyPopupButton��$��X��$
��Bold"�$��4q�$��Right=�$
 Hand��� $��1��$��20q� �� $
��Auto ��� $��* � �� $
��Auto ��� $��* ��� $
��Auto ��� $
��Auto ��� $
��Auto �.+��� $	��Nom���� -   $ ModifyNameInput��$��1��$��Center=��� $��1��$��Description���� -   $ ModifyDescriptionInput��$��1��$��1���� $��2��$
��uPHT���� -   $ ModifypUHTInput��$��2��$��1��$��Center=��� $��3��$��Gamme���� -   $	 ModifyRangeInput��$��3��$��1��$��80��$��0,0,0,10q�$��4q����� #
 [  �� -   $ ModifyValidationButton��$��0,10,0,0q�$��1��$��4��$��Right=�$
��8, 4q�.��
Modifier