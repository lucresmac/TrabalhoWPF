   M S B A M L   `   `   `  ����C  ?Hospital, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Hospital.ViewsHospital.Views  5   	       Hospital.Views.frmMedico   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:Hospital.Views     5   	     � Title$  	frmMedico��5   	   $	��523��6   $	��459��6(    � WindowStartupLocation$ CenterScreen=�64   $��16(�6Y   $��Medium"�6g   .��5	      � .+�5
   
   �� $%��Cadastrar Prescrição Paciente��6   $��18(�68   $
��Left=�6F   $��	10,10,0,0q�6a   $	��Top=�6t   �� 5   
   $��Selecione o paciente��6   $
��Left=�6/   $	��Top=�6K   $��	10,49,0,0q�6c   &   System.Windows.Controls.DataGrid  5   
   -   5        $
��grid��5      $��10,85,10,329q�6      AutoGenerateColumns$ False��65      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Tipo do atendimento��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 1* 6\   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6B   �� *Tipo+6j     5      $
 Nome��6%   $ 1* 6M    63   �� *Nome+6[     5      $ Sintomas��6%   $ 1* 6U    67   �� *
Sintomas+6c   5        5   
   -   5        $��grid_prescricao��5      $��10,212,10,180q�6*   $ False��6A    5        5      $ 
Prescricao��6%   $ 1* 6`    6;   �� *TextoPrescricao+6n   5      �� 5   
   $��Prescrição��6   $
��Left=�6%   $	��Top=�6A   $��
10,176,0,0q�6Y   �� 5   
   $��Descreva a prescrição��6   $
��Left=�60   $	��Top=�6L   $��
10,332,0,0q�6d   �� 5   
   -   5        $��txtPrescricao��5      $��Center=�6'   $��	0,368,0,0q�6D   " �� VerticalScrollBarVisibility$ Visible=�6W    �� TextWrapping$
 Wrap=�6}   $	��Top=�6�   $	��439��6�   $��74��6�   �� 5   
   -   5        $��btnCadastrar��5   %   $��	Cadastrar��6   $
��Left=�69   $��
10,457,0,0q�6T   $	��Top=�6h   6�   �� 5   
   -   5        $��
btnAlterar��5   #   $��Alterar��6   $
��Left=�65   $��
96,457,0,0q�6P   $	��Top=�6d   $y�Hidden=�6|   6�   �� 5   
   -   5        $��
btnRemover��5   #   $��Remover��6   $
��Left=�65   $��165,457,0,0q�6P   $	��Top=�6e   $y�Hidden=�6}   6�   5      5      