<template>
  <div>
    <h1>Novo lançamento</h1>
    <v-form v-model="valid">
      <v-container>
        <v-row justify="center" align="center">
          <v-col cols="12" lg="6">
            <v-row>
              <v-col cols="12" md="12">
                <v-text-field
                  v-model="transaction.title"
                  label="Titulo"
                  required
                  outlined
                />
              </v-col>

              <v-col cols="12" md="6">
                <v-currency-field
                  v-model="transaction.value"
                  label="Valor"
                  required
                  outlined
                />
              </v-col>
              <v-col cols="12" md="6">
                <v-menu
                  v-model="menu2"
                  :close-on-content-click="false"
                  :nudge-right="40"
                  transition="scale-transition"
                  offset-y
                  min-width="290px"
                >
                  <template v-slot:activator="{ on, attrs }">
                    <v-text-field
                      v-model="transaction.date"
                      label="Data"
                      append-icon="mdi-calendar"
                      readonly
                      outlined
                      v-bind="attrs"
                      v-on="on"
                    />
                  </template>
                  <v-date-picker
                    v-model="transaction.date"
                    @input="menu2 = false"
                  />
                </v-menu>
              </v-col>
              <v-col cols="12" md="3">
                <v-select
                  v-model="transaction.type"
                  :items="types"
                  label="Tipo"
                  required
                  outlined
                />
              </v-col>
              <v-col v-show="!isEntrada" cols="12" md="3">
                <v-select
                  v-model="transaction.category"
                  :items="categories"
                  label="Categoria"
                  required
                  outlined
                />
              </v-col>
              <v-col cols="12" md="3">
                <v-autocomplete
                  v-model="transaction.tags"
                  :items="tags"
                  chips
                  small-chips
                  label="Tags"
                  multiple
                  outlined
                />
              </v-col>
              <v-col v-show="!isEntrada" cols="12" md="3">
                <v-select
                  v-model="transaction.parcel"
                  :items="parcels"
                  label="Parcelamento"
                  outlined
                />
              </v-col>
            </v-row>
            <v-row>
              <v-col cols="12" md="2">
                <v-btn large outlined color="primary" to="/">
                  Voltar
                </v-btn>
              </v-col>
              <v-col>
                <v-btn large color="primary">
                  Gravar
                </v-btn>
              </v-col>
            </v-row>
          </v-col>
        </v-row>
      </v-container>
    </v-form>
  </div>
</template>

<script>
import { mapMutations } from 'vuex'
export default {
  data () {
    return {
      transaction: {
        title: '',
        value: 0,
        date: '',
        type: ''
      },
      types: ['Entrada', 'Saída'],
      tags: ['Lanche', 'Casa', 'Carro'],
      categories: ['Lazer', 'Educação', 'Alimentação', 'Saúde'],
      parcels: ['Á vista', '2x', '3x', '4x'],
      menu2: false,
      valid: false
    }
  },
  computed: {
    isEntrada () {
      return this.type === 'Entrada'
    }
  },
  methods: {
    registerTransaction () {
      this.addTransaction(this.transaction)
      this.$toast.success('Lançamento realizado!')
    },
    ...mapMutations(['addTransaction'])
  }
}
</script>
