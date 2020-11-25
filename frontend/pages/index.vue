<template>
  <div>
    <v-row justify="center" align="center">
      <v-col cols="12">
        <v-btn color="secondary" large to="transaction/new">
          <v-icon>mdi-plus</v-icon> &nbsp; Novo Lançamento
        </v-btn>
      </v-col>
      <v-col cols="12" sm="12" md="12">
        <v-simple-table fixed-header height="300px">
          <template v-slot:default>
            <thead>
              <tr>
                <th class="text-left">
                  Nome
                </th>
                <th class="text-left">
                  Valor
                </th>
                <th class="text-left">
                  Categoria
                </th>
                <th class="text-left">
                  Data
                </th>
                <th class="text-left">
                  Parcela
                </th>
                <th class="text-left">
                  Tipo
                </th>
                <th class="text-left">
                  Tags
                </th>
              </tr>
            </thead>
            <tbody>
              <tr v-for="item in transactions" :key="item.title">
                <td>{{ item.title }}</td>
                <td>{{ item.value | currency }}</td>
                <td>{{ item.category }}</td>
                <td>{{ item.date | dateParse('YYYY-MM-DD') | dateFormat("DD/MM/YYYY") }}</td>
                <td>{{ item.parcel }}</td>
                <td>{{ item.type }}</td>
                <td>
                  <v-chip v-for="tag in item.tags" :key="tag">
                    {{ tag }}
                  </v-chip>
                </td>
              </tr>
            </tbody>
          </template>
        </v-simple-table>
      </v-col>
    </v-row>
  </div>
</template>

<script>
import { mapGetters } from 'vuex'
export default {
  components: {},
  data () {
    return {

    }
  },
  computed: {
    ...mapGetters([
      'transactions'
    ])
  }
}
</script>
