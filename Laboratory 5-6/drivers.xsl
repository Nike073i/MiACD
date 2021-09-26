<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0"
                xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    <xsl:template match="/">
        <html>
            <body>
                <h2>
                    <u>
                        <i>Водители:</i>
                    </u>
                </h2>
                <table border="1" cols="4" cellpadding="10">
                    <tr bgcolor="#ff6600">
                        <th>id</th>
                        <th>Имя</th>
                        <th>Фамилия</th>
                        <th>Номер телефона</th>
                    </tr>
                    <xsl:for-each select="drivers/driver">
                        <xsl:sort select="@id"/>
                        <tr>
                            <td>
                                <xsl:value-of select="@id"/>
                            </td>
                            <td>
                                <xsl:value-of select="first_name"/>
                            </td>
                            <td>
                                <xsl:value-of select="second_name"/>
                            </td>
                            <td>
                                <xsl:value-of select="contact_num"/>
                            </td>
                        </tr>
                    </xsl:for-each>
                </table>
            </body>
        </html>
    </xsl:template>
</xsl:stylesheet>