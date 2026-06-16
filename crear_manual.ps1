$outputPath = "C:\Users\diego\OneDrive\source\repos\GrupoE_Tutasa\Manual_CicloVidaGuia.docx"

$word = New-Object -ComObject Word.Application
$word.Visible = $false
$doc = $word.Documents.Add()
$sel = $word.Selection

$sel.Style = $doc.Styles.Item("Título")
$sel.TypeText("Manual de Operaciones — Ciclo de Vida de una Guía")
$sel.TypeParagraph()
$sel.Style = $doc.Styles.Item("Normal")
$sel.TypeText("El recorrido de una guía varía según dos variables: cómo la impone el cliente (modalidad de imposición) y cómo quiere recibirla el destinatario (modalidad de entrega). Hay partes del flujo que son comunes a todos los casos.")
$sel.TypeParagraph()

function Add-Table($doc, $sel, $data) {
    $tbl = $doc.Tables.Add($sel.Range, $data.Count + 1, 3)
    $tbl.Borders.Enable = $true
    $tbl.Rows.Item(1).Cells.Item(1).Range.Text = "Paso"
    $tbl.Rows.Item(1).Cells.Item(2).Range.Text = "Formulario / Acción"
    $tbl.Rows.Item(1).Cells.Item(3).Range.Text = "Estado resultante"
    $tbl.Rows.Item(1).Range.Font.Bold = $true
    $tbl.Rows.Item(1).Shading.BackgroundPatternColor = 4996353
    $tbl.Rows.Item(1).Range.Font.Color = 16777215
    for ($i = 0; $i -lt $data.Count; $i++) {
        $tbl.Rows.Item($i + 2).Cells.Item(1).Range.Text = $data[$i][0]
        $tbl.Rows.Item($i + 2).Cells.Item(2).Range.Text = $data[$i][1]
        $tbl.Rows.Item($i + 2).Cells.Item(3).Range.Text = $data[$i][2]
    }
    $sel.MoveDown(5, 1)
    $sel.TypeParagraph()
}

# PARTE 1
$sel.Style = $doc.Styles.Item("Título 1")
$sel.TypeText("Parte 1 — Imposición (siempre es el primer paso)")
$sel.TypeParagraph()

$sel.Style = $doc.Styles.Item("Título 2")
$sel.TypeText("Imposición en CD")
$sel.TypeParagraph()
$sel.Style = $doc.Styles.Item("Normal")
$sel.TypeText("El cliente lleva la caja directamente al CD. La guía ya está en el CD, no necesita retiro.")
$sel.TypeParagraph()
Add-Table $doc $sel @(,@("1","Imposición","RENDIDA"))
$sel.TypeText("Continuar en Parte 2.")
$sel.TypeParagraph()

$sel.Style = $doc.Styles.Item("Título 2")
$sel.TypeText("Imposición en Agencia")
$sel.TypeParagraph()
$sel.Style = $doc.Styles.Item("Normal")
$sel.TypeText("El cliente lleva la caja a una agencia.")
$sel.TypeParagraph()
Add-Table $doc $sel @(
    @("1","Imposición","A_RETIRAR"),
    @("2","Generar HDR Fletero (tipo Retiro)","A_RETIRAR (se genera la HDR)"),
    @("3","Rendición HDR (tipo Retiro) — fletero va a la agencia y trae la caja al CD","RENDIDA")
)
$sel.TypeText("Continuar en Parte 2.")
$sel.TypeParagraph()

$sel.Style = $doc.Styles.Item("Título 2")
$sel.TypeText("Imposición en Domicilio")
$sel.TypeParagraph()
$sel.Style = $doc.Styles.Item("Normal")
$sel.TypeText("El cliente solicita que pasen a retirar la caja por su domicilio.")
$sel.TypeParagraph()
Add-Table $doc $sel @(
    @("1","Imposición","A_RETIRAR"),
    @("2","Generar HDR Fletero (tipo Retiro)","A_RETIRAR (se genera la HDR)"),
    @("3","Rendición HDR (tipo Retiro) — fletero va al domicilio del cliente y trae la caja al CD","RENDIDA")
)
$sel.TypeText("Continuar en Parte 2.")
$sel.TypeParagraph()

# PARTE 2
$sel.Style = $doc.Styles.Item("Título 1")
$sel.TypeText("Parte 2 — Admisión en CD Origen (común a todos los casos)")
$sel.TypeParagraph()
$sel.Style = $doc.Styles.Item("Normal")
$sel.TypeText("La guía está en el CD con estado RENDIDA. El operador la admite, verifica el tamaño y genera el cargo.")
$sel.TypeParagraph()
Add-Table $doc $sel @(,@("4","Admisión","EN_CD_DESTINO (si el CD destino es el mismo) o ADMITIDA (si debe viajar)"))
$sel.TypeText("Si quedó EN_CD_DESTINO, saltar a Parte 4. Si quedó ADMITIDA, continuar en Parte 3.")
$sel.TypeParagraph()

# PARTE 3
$sel.Style = $doc.Styles.Item("Título 1")
$sel.TypeText("Parte 3 — Transporte entre CDs (solo si origen ≠ destino)")
$sel.TypeParagraph()
Add-Table $doc $sel @(
    @("5","Generar HDR Transporte — agrupa guías ADMITIDA con destino al mismo CD","TRASLADADA"),
    @("6","Recepción/Despacho CD Larga Distancia (en el CD destino) — confirma la llegada","EN_CD_DESTINO")
)

# PARTE 4
$sel.Style = $doc.Styles.Item("Título 1")
$sel.TypeText("Parte 4 — Entrega (varía según modalidad de entrega)")
$sel.TypeParagraph()

$sel.Style = $doc.Styles.Item("Título 2")
$sel.TypeText("Entrega en Domicilio")
$sel.TypeParagraph()
$sel.Style = $doc.Styles.Item("Normal")
$sel.TypeText("El fletero lleva la caja al domicilio del destinatario.")
$sel.TypeParagraph()
Add-Table $doc $sel @(
    @("7","Generar HDR Fletero (tipo Distribución)","EN_DISTRIBUCION"),
    @("8","Rendición HDR (tipo Distribución) — fletero entregó en domicilio","ENTREGADA")
)

$sel.Style = $doc.Styles.Item("Título 2")
$sel.TypeText("Entrega en Agencia")
$sel.TypeParagraph()
$sel.Style = $doc.Styles.Item("Normal")
$sel.TypeText("El fletero lleva la caja a la agencia destino; el destinatario la retira ahí.")
$sel.TypeParagraph()
Add-Table $doc $sel @(
    @("7","Generar HDR Fletero (tipo Distribución)","EN_DISTRIBUCION"),
    @("8","Rendición HDR (tipo Distribución) — fletero dejó la caja en la agencia","EN_AGENCIA_DESTINO"),
    @("9","Entrega en Agencia — destinatario se presenta con DNI y retira la caja","ENTREGADA")
)

$sel.Style = $doc.Styles.Item("Título 2")
$sel.TypeText("Entrega en CD")
$sel.TypeParagraph()
$sel.Style = $doc.Styles.Item("Normal")
$sel.TypeText("El destinatario va directamente al CD a retirar la caja.")
$sel.TypeParagraph()
Add-Table $doc $sel @(,@("7","Entrega en CD — destinatario se presenta con DNI y retira la caja","ENTREGADA"))

# PARTE 5
$sel.Style = $doc.Styles.Item("Título 1")
$sel.TypeText("Parte 5 — Facturación (siempre es el último paso)")
$sel.TypeParagraph()
Add-Table $doc $sel @(,@("Último","Emitir Factura","Marca los cargos de la guía como facturados en la cuenta corriente del cliente"))

# RESUMEN
$sel.Style = $doc.Styles.Item("Título 1")
$sel.TypeText("Resumen — Camino más largo")
$sel.TypeParagraph()
$sel.Style = $doc.Styles.Item("Normal")
$sel.TypeText("(Imposición en domicilio + entrega en domicilio + transporte entre CDs)")
$sel.TypeParagraph()
$sel.TypeParagraph()
$sel.Font.Bold = $true
$sel.TypeText("Imposición  →  Generar HDR Retiro  →  Rendición HDR Retiro  →  Admisión  →  Generar HDR Transporte  →  Recepción/Despacho CD  →  Generar HDR Distribución  →  Rendición HDR Distribución  →  Emitir Factura")
$sel.Font.Bold = $false

$doc.SaveAs2($outputPath, 16)
$doc.Close($false)
$word.Quit()
Write-Output "LISTO: $outputPath"
